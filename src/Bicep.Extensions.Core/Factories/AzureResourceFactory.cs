using Bicep.Extensions.Core.Models;
using static Bicep.Extensions.Core.CoreConstants;

namespace Bicep.Extensions.Core.Factories
{
    public class AzureResourceFactory : IAzureResourceFactory
    {
        public AzureResourceModel Create(string symbolicName, string azureResourceTypeName, string verison, string kind, string location, string skuName, AzureResourcePropertiesModel properties)
        {
            return new AzureResourceModel()
            {
                SymbolicName = symbolicName,                
                Kind = kind,
                Type = new AzureResourceType()
                {
                    Name = azureResourceTypeName,
                    Version = verison
                },
                Sku = new AzureSkuModel
                {
                    Name = skuName
                },
                Location = location,
                Properties = properties
            };
        }

        public AzureResourceModel Create(string symbolicName, string name, string verison, string kind, string skuName, AzureResourcePropertiesModel properties)
        {
            return Create(symbolicName, name, verison, kind, "resourceGroup().location", skuName, properties);
        }

        public AzureResourceModel CreateStorageAccount(string name)
            => new AzureResourceModel()
            {
                SymbolicName = "storageAccount",
                Kind = "StorageV2",
                Name = name,
                Type = new ()
                {
                    Name = "Microsoft.Storage/storageAccounts",
                    Version = "2021-08-01"
                },
                Sku = new ()
                {
                    Name = AzureStorageAccountResource.SkuNames.Standard
                },
                Properties = AzureResourcePropertiesModel.Parse("storageAccount", "{ accessTier: \"Hot\" }")
            };

        public AzureResourceModel CreateAppServicePlan()
        {
            throw new NotImplementedException();
        }
    }
}
