using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public class ModuleSignatureGenerationStrategy: IModuleSignatureGenerationStrategy
    {
        public string Create(ModuleModel model) => $"module";
    }
}
