using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public class AzureStorageResourcePropertiesGenerationStrategy : IAzureResourcePropertiesGenerationStrategy
    {
        public bool CanHandle(AzureResourcePropertiesModel model) => model.AzureResourceSymbolicName == CoreConstants.SymbolicNames.StorageAccount;

        public string[] Create(AzureResourcePropertiesModel model)
        {
            throw new NotImplementedException();
        }
    }
}
