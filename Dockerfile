FROM microsoft/dotnet:latest
COPY . /app
WORKDIR /app

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

ENV ASPNETCORE_URLS http://*:6001
EXPOSE 6001/tcp

ENTRYPOINT ["dotnet", "run"]

