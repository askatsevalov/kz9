FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . .
RUN dotnet publish -c Release -o publish

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:5.0
ARG SERVER_PORT=5000
EXPOSE ${SERVER_PORT}
ENV ASPNETCORE_URLS=http://+:${SERVER_PORT}/
WORKDIR /app
COPY --from=build-env /app/publish .

# Install python and requirements
RUN apt-get update -y && apt-get install python3 python3-pip -y
RUN pip3 install --default-timeout=100 -r ./Colorizer/requirements.txt

ENTRYPOINT ["dotnet", "Server.dll"]