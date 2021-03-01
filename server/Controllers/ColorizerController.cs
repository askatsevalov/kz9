using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Data.Contexts;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Models;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorizerController : ControllerBase
    {
        private DataBaseContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly ILogger _logger;

        public ColorizerController(DataBaseContext context, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            _context = context;
            _env = env;
            _logger = loggerFactory.CreateLogger<ColorizerController>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Photo>> GetPhotoById(int id)
        {
            var result = await _context.Photos.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [DisableRequestSizeLimit]
        [HttpPost("")]
        public async Task<ActionResult<Photo>> UploadPhoto()
        {
            try
            {
                var photo = Request.Form.Files?[0];
                if (photo?.Length > 0)
                {
                    var ext = Path.GetExtension(photo.FileName);
                    var name = Guid.NewGuid().ToString() + ext;
                    var filePath = GetFullPath(name);

                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await photo.CopyToAsync(stream);
                    }

                    var result = (await _context.Photos.AddAsync(new Photo
                    {
                        Name = name,
                        Type = "input",
                        ReferenceId = null,
                    })).Entity;
                    await _context.SaveChangesAsync();

                    return Ok(result);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("{id}")]
        public async Task<ActionResult<Photo>> ColorizePhoto(int id)
        {
            try
            {
                var photo = await _context.Photos.FirstOrDefaultAsync(x => x.Id == id && x.Type == "input");
                if (photo == null)
                {
                    return NotFound();
                }

                ProcessStartInfo colorizer = new ProcessStartInfo();
                colorizer.FileName = "/usr/bin/python3";
                colorizer.WorkingDirectory = "Colorizer/";
                var ext = photo.Name.Split('.').Last();
                var outName = $"{Guid.NewGuid().ToString()}.{ext}";
                colorizer.Arguments = string.Format($"colorize.py -i {GetFullPath(photo.Name)} -o {GetFullPath(outName)}");
                colorizer.UseShellExecute = false;
                colorizer.RedirectStandardOutput = true;
                colorizer.CreateNoWindow = true;

                Photo result = null;
                using (Process process = Process.Start(colorizer))
                {
                    await process.WaitForExitAsync();
                    if (process.ExitCode == 0)
                    {
                        result = (await _context.Photos.AddAsync(new Photo
                        {
                            Name = outName,
                            Type = "output",
                            ReferenceId = photo.Id,
                        })).Entity;
                        await _context.SaveChangesAsync();
                    }
                }
                if (result == null)
                {
                    return BadRequest();
                }

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
        }

        private string GetFullPath(string name)
        {
            var dir = $"{_env.WebRootPath}/storage";
            if (!Directory.Exists(dir))
            {
                _logger.LogCritical("CREATING DIRECTORY");
                Directory.CreateDirectory(dir);
            }
            return $"{dir}/{name}";
        }
    }
}