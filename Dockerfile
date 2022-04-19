
FROM mcr.microsoft.com/dotnet/aspnet:3.1.23-bullseye-slim-arm32v7
WORKDIR /App
#RUN mkdir -p /eboncuk
#COPY --from=build /eBoncuk ./
#COPY /out ./eboncuk
#WORKDIR /App/eboncuk
COPY /out .
ENTRYPOINT ["dotnet", "backend/backend.dll"]
