
FROM mcr.microsoft.com/dotnet/aspnet:3.1.23-bullseye-slim-arm32v7

WORKDIR /App
COPY ../frontend/dist/frontend /frontend/dist
COPY /out .

ENTRYPOINT ["dotnet", "backend.dll"]
