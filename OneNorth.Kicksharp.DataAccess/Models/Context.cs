namespace OneNorth.Kicksharp.DataAccess.Models
{
    public class Context
    {
        public Context(string language)
        {
            Language = language;
        }

        public string Language { get; }
    }
}
