FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS runtime
WORKDIR /app
COPY out/ ./
EXPOSE 80
ENTRYPOINT ["dotnet", "MeuSite.dll"]