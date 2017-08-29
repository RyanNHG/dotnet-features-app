# kicksharp
Playing around with .NET Core

### Project Structure

```
Data/
- Repos (fetch data from db context)
- Models (persistence models)
- Utilities (reusable functions that transform data)

Logic/
- Services (convert persistence models to domain models)
- Models (domain models)
- Utilities (reusable functions that transform data)

Web/
- Components (partials that fetch their own data)
  - Navbar (example component)
    - ViewModel.cs (model)
    - Index.cshtml (view)
    - Component.cs (controller)
- Config (project configuration)
- Layouts (base html layouts for pages)
- Models (reusable, view-independent classes)
- Pages (pages for the website)
  - Home (example page)
    - ViewModel.cs (model)
    - Index.cshtml (view)
    - HomeController.cs (controller)
- Utilities (reusable functions that transform data)
```
