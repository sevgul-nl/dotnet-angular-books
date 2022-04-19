
FROM mcr.microsoft.com/dotnet/aspnet:3.1.23-bullseye-slim-arm32v7
WORKDIR /App
COPY /out .
ENTRYPOINT ["dotnet", "backend.dll"]
