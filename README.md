# Kicksharp
> A .NET core templating project.

### Local Development - Docker

1. __`docker-compose up`__

### Local Development - Without Docker

1. Make sure you have the [.NET Core SDK](https://www.microsoft.com/net/download/core) installed.

1. __`dotnet restore`__ (Equivalent of `npm install` in NodeJS)

1. __`npm install`__

1. __`npm install -g gulp-cli`__

1. __`gulp dev`__

1. Run either:
    
    - __`dotnet run`__ (Equivalent of `node app.js` in NodeJS)

    - __`dotnet watch run`__ (Equivalent of `nodemon app.js` in NodeJS)

1. Check out [http://localhost:5000](http://localhost:5000)

---

### Project Overview

Here is a quick introduction of the files and folders in this project:

__.NET Core Things__

Name | Description
--- | ---
`/project.csproj` | Lists project dependencies (Equivalent of `package.json` in NodeJS)
`/Program.cs` | Entrypoint to application
`/Config` | Configuration for MVC application
`/Routes` | All frontend routes (includes controllers, views, and models)

__NodeJS Things__

Name | Description
--- | ---
`/package.json` | Packages needed for building assets
`/gulpfile.js` | Gulp tasks for bundling assets
`/styles/` | SCSS files for styling
