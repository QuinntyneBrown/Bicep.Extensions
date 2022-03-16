using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public interface IAzureResourceSignatureGenerationStrategy
    {
        string Create(AzureResourceModel model);
    }
    public class AzureResourceSignatureGenerationStrategy: IAzureResourceSignatureGenerationStrategy
    {
        public string Create(AzureResourceModel model) => $"resource {model.SymbolicName} '{model.Type.Name}@{model.Type.Version}' =" + " {";
    }
}
