using Bicep.Extensions.Core.Extensions;
using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public class AzureStorageResourceGenerationStrategy : IAzureResourceGenerationStrategy
    {
        private readonly ISkuGenerationStrategy _skuGenerationStrategy;
        private readonly IAzureResourceSignatureGenerationStrategy _azureResourceSignatureGenerationStrategy;
        public AzureStorageResourceGenerationStrategy(ISkuGenerationStrategy skuGenerationStrategy, IAzureResourceSignatureGenerationStrategy azureResourceSignatureGenerationStrategy)
        {
            _skuGenerationStrategy = skuGenerationStrategy;
            _azureResourceSignatureGenerationStrategy = azureResourceSignatureGenerationStrategy;
        }

        public bool CanHandle(AzureResourceModel model) => model.SymbolicName == CoreConstants.SymbolicNames.StorageAccount;

        public string[] Create(AzureResourceModel model)
        {
            List<string> content = new List<string>();

            content.Add(_azureResourceSignatureGenerationStrategy.Create(model));

            content.Add($"name: {model.InstanceUniqueName}".Indent(1));

            content.Add($"location: resourceGroup().location".Indent(1));

            content.Add($"kind: '{model.Kind}'".Indent(1));

            content.AddRange(_skuGenerationStrategy.Create(model.Sku).Indent(1));
            
            content.Add("}");

            return content.ToArray();
        }
    }
}
