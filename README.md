# Kicksharp
> A .NET Core templating project.

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

### Architecture

The architecture was mainly inspired by Microsoft's [MVC Guide](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview) with the addition of [Feature Slices](https://msdn.microsoft.com/en-us/magazine/mt763233.aspx) to make the application's structure less frustrating.

Essentially our solution is broken up into three layers:
![Architecture](https://raw.githubusercontent.com/RyanNHG/dotnet-features-app/master/architecture.png)

#### 1. Web Layer

The web application. This has __views__, __controllers__, and __view models__.

- __Views__ - Templates that take in pre-populated view models.

- __Controllers__ - Use services from the logic layer to populate view models.

- __View Models__ - Simple model for rendering a view.


#### 2. Logic Layer

The logic layer has __domain models__ and __services__. It handles all the business logic and functionality required by the organization.

- __Domain Models__ - Models that don't depend on how the data is viewed or stored.

- __Services__ - Uses repositories to fetch persistence models, then uses logic to transform to domain models.


#### 3. Data Layer

The data layer has __repositories__ and __persistence models__, based on the actual database or content management system.

- __Persistence Models__ - Models that reflect how data is stored, depends on DB / CMS implementation.

- __Repositories__ - Simple classes for retrieving / updating for models.

---

### Folder Structure Overview

Here is a quick introduction of the files and folders in this project:

__.NET Core Things__

Name | Description
--- | ---
`/project.csproj` | Lists project dependencies (Equivalent of `package.json` in NodeJS)
`/Program.cs` | Entrypoint to application
`/Web/Config` | Configuration for MVC application
`/Web/styles` | The SCSS project.
`/Web/Utilities` | Reusable utilities for transforming domain models to view models.
`/Web/Views` | All frontend routes (contains controllers, views, and view models).
`/Logic/Models` | All domain model interfaces.
`/Logic/Services` | All service interfaces.
`/Logic/Types` | Data structures used in domain models.
`/Logic.<Implementation>/Models` | Implementation of domain model interfaces.
`/Logic.<Implementation>/Services` | Implementation of service interfaces.
`/Data/Models` | All persistence model interfaces.
`/Data/Repos` | All repositories and repository interfaces.
`/Data.<Implementation>/Models` | Implementation of persistence model interfaces.
`/Data.<Implementation>/Repos` | Implementation of repositories and repository interfaces.

__NodeJS Things__

Name | Description
--- | ---
`/package.json` | Packages needed for building assets
`/gulpfile.js` | Gulp tasks for bundling assets
`/Web/styles` | SCSS files for styling
`/Web/public` | Output directory for web application

---
