namespace Kicksharp.Logic.Json
{
    public interface IMocker
    {
        string GetPathPrefix();
        T GetJson<T>(string filename);
    }
}