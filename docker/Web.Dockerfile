FROM microsoft/dotnet:latest

RUN mkdir -p /usr/src/app/Web
WORKDIR /usr/src/app/Web

COPY ./Web/Web.csproj .
RUN dotnet restore

EXPOSE 5000

CMD ["dotnet", "watch", "run"]
