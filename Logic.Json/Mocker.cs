using Json = Newtonsoft.Json;
using JObject = Newtonsoft.Json.Linq.JObject;
using System.IO;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace Kicksharp.Logic.Json
{
    public class Mocker : IMocker
    {
        private const string mockJsonFolder = "Logic.Json/Json";
        private string pathPrefix;
        private bool throwExceptionOnInvalidJson;

        private class InvalidJsonException : System.Exception
        {
            public InvalidJsonException(string str) : base(str)
            {

            }
        }

        public Mocker(string rootDirectory, bool throwExceptionOnInvalidJson = true)
        {
            this.pathPrefix = Path.Combine(rootDirectory, mockJsonFolder);
            this.throwExceptionOnInvalidJson = throwExceptionOnInvalidJson;
        }

        public string GetPathPrefix()
        {
            return this.pathPrefix;
        }

        public T GetJson<T>(string filename)
        {
            string filepath = Path.Combine(this.pathPrefix, filename);
            JObject jObject = JObject.Parse(File.ReadAllText(filepath));

            T thing = jObject.ToObject<T>();

            List<string> nullProperties =
                GetNullProperties(thing.GetType().FullName, thing).ToList();

            if (nullProperties.Any())
            {
                string message = System.String.Join("\n", nullProperties
                    .Select(str => "\t- " + str)
                    .Prepend("\nThese properties are missing from '" + filepath + "':"));

                if (throwExceptionOnInvalidJson)
                {
                    throw new InvalidJsonException(message);
                }
                else
                {
                    System.Console.WriteLine(message);
                }
            }

            return thing;
        }

        private IEnumerable<string> GetNullProperties<T>(string prefix, T obj)
        {
            return obj.GetType().GetProperties()
                .SelectMany(pi =>
                {
                    var child = pi.GetValue(obj);

                    if (child == null)
                    {
                        return new List<string>() { prefix + "." + pi.Name };
                    }
                    else if (child.GetType().Namespace.Contains(this.GetType().Namespace.Split('.').First()))
                    {
                        return GetNullProperties(prefix + "." + child.GetType().Name, child);
                    }
                    else
                    {
                        return new List<string>();
                    }
                });
        }
    }
}