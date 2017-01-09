FROM microsoft/dotnet:latest
COPY . /app
WORKDIR /app

RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

ENV ASPNETCORE_URLS http://*:6001
EXPOSE 4001/tcp

ENTRYPOINT ["dotnet", "run"]

