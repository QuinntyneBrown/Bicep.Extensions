using Bicep.Extensions.Core.Models;
using Newtonsoft.Json.Linq;

namespace Bicep.Extensions.Core.Factories
{
    public class AzureResourceFactory : IAzureResourceFactory
    {
        public AzureResourceModel Create(string symbolicName, string name, string instanceUniqueName, string verison, string kind, string location, string skuName, JObject properties)
        {
            return new AzureResourceModel()
            {
                SymbolicName = symbolicName,
                Name = name,
                InstanceUniqueName = $"{instanceUniqueName}-{Guid.NewGuid()}",
                Type = new AzureResourceType()
                {
                    Name = name,
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

        public AzureResourceModel CreateStorageAccount()
            => Create(
                "storageAccount",
                "Microsoft.Storage/storageAccounts",
                "instance",
                "2021-08-01",
                "StorageV2",
                "westus3",
                "Standard_LRS");
    }
}
