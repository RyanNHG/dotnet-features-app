using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Razor;

namespace Kicksharp.Web.Config
{
    internal class FeatureConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            string pageName = GetName(controller.ControllerType, "pages");
			string componentName = GetName(controller.ControllerType, "component");

			controller.Properties.Add("page", pageName);
            controller.Properties.Add("component", componentName);
		}

        private string GetName(TypeInfo controllerType, string lowercaseName)
        {
            return controllerType
                .FullName
                .Split('.')
                .SkipWhile(t => !t.Equals(lowercaseName, StringComparison.CurrentCultureIgnoreCase))
                .Skip(1)
                .FirstOrDefault() ?? "";
        }

		public void RazorOptions(RazorViewEngineOptions options)
		{
			const string actionName = "{0}";
			// const string controllerName = "{1}";
			// const string areaName = "{2}";
			const string pageName = "{3}";
			const string componentName = "{4}";

			options.ViewLocationFormats.Clear();
			options.ViewLocationFormats.Add($"/Pages/{pageName}/{actionName}.cshtml");
			options.ViewLocationFormats.Add($"{componentName}/{actionName}.cshtml");
			options.ViewLocationExpanders.Add(new FeatureLocationExpander());
		}

        private class FeatureLocationExpander : IViewLocationExpander
        {
            public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
            {
                ControllerActionDescriptor descriptor = (ControllerActionDescriptor) context.ActionContext.ActionDescriptor;

                string pageName = (string)descriptor.Properties["page"];
                string componentName = (string)descriptor.Properties["component"];

                foreach (string location in viewLocations)
                {
                    yield return location
                        .Replace("{3}", pageName)
                        .Replace("{4}", componentName);
                }
            }

            public void PopulateValues(ViewLocationExpanderContext context)
            {
                // Do nothing...
            }
        }
    }
}