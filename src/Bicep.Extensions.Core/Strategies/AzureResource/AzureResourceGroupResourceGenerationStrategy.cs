using Bicep.Extensions.Core.Extensions;
using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public class AzureResourceGroupResourceGenerationStrategy : IAzureResourceGenerationStrategy
    {
        private readonly IAzureResourceSignatureGenerationStrategy _azureResourceSignatureGenerationStrategy;
        public AzureResourceGroupResourceGenerationStrategy(IAzureResourceSignatureGenerationStrategy azureResourceSignatureGenerationStrategy)
        {
            _azureResourceSignatureGenerationStrategy = azureResourceSignatureGenerationStrategy;
        }

        public bool CanHandle(AzureResourceModel model) => model.SymbolicName == CoreConstants.SymbolicNames.ResourceGroup;

        public string[] Create(AzureResourceModel model)
        {
            List<string> content = new List<string>();

            content.Add(_azureResourceSignatureGenerationStrategy.Create(model));

            content.Add($"name: {model.Name}".Indent(1));

            content.Add($"location: {model.Location}".Indent(1));

            content.Add("}");

            return content.ToArray();
        }
    }
}

