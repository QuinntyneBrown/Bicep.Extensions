
namespace Bicep.Extensions.Core
{
    public interface INamespaceProvider
    {
        string Get(string directory, int depth = 0);
    }
}
