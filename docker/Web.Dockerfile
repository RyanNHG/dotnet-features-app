FROM microsoft/dotnet:latest

RUN mkdir -p /usr/src/app
WORKDIR /usr/src/app

COPY project.csproj /usr/src/app
RUN dotnet restore

EXPOSE 5000

CMD ["dotnet", "watch", "run"]
