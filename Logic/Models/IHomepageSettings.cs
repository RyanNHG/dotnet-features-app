using Kicksharp.Logic.Types;

namespace Kicksharp.Logic.Models
{
    public interface IHomepageSettings
    {
        HeaderSection HeaderSection { get; }
        IntroSection IntroSection { get; }
        LinksSection LinksSection { get; }
    }
}