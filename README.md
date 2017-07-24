# Kicksharp
> A .NET core templating project.

### Local Development

1. Make sure you have the [.NET Core SDK](https://www.microsoft.com/net/download/core) installed.

1. __`dotnet restore`__ (Equivalent of `npm install`)

1. Run either:
    
    - __`dotnet run`__ (Equivalent of `node app.js`)

    - __`dotnet watch run`__ (Equivalent of `nodemon app.js`)

1. Check out [http://localhost:5000](http://localhost:5000)

### Project Overview

Here is a quick introduction of the files and folders in this project:

Name | Description
--- | --- | ---
`/project.csproj` | Lists project dependencies (Like `package.json`)
`/Program.cs` | Entrypoint to application
`/Config` | Configuration for MVC application
`/Routes` | All frontend routes (includes controllers, views, and models)
