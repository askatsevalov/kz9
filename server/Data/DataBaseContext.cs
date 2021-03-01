using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Data.Contexts
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Photo> Photos { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}