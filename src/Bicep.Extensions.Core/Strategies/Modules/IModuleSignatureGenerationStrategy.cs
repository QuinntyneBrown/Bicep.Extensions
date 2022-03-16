using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public interface IModuleSignatureGenerationStrategy
    {
        string Create(ModuleModel model);
    }
}
