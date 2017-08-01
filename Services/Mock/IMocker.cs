namespace Kicksharp.Services.Mock
{
    public interface IMocker
    {
        string GetPathPrefix();
        T GetJson<T>(string filename);
    }
}