using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core
{
    public interface IModuleFactory
    {
        ModuleModel Create(string name);
    }
}
