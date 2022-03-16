using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core
{
    public class ModuleFactory : IModuleFactory
    {
        public ModuleModel Create(string name)
        {
            return new ModuleModel()
            {

            };
        }
    }
}
