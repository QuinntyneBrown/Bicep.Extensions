using Bicep.Extensions.Core.Extensions;
using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public class AzureStorageSkuGenerationStrategy : ISkuGenerationStrategy
    {
        public bool CanHandle(AzureSkuModel model) => model.AzureResourceSymbolicName == CoreConstants.SymbolicNames.StorageAccount;

        public string[] Create(AzureSkuModel model)
            => new List<string>
            {
                "sku: {",
                $"name: '{model.Name}'".Indent(1),
                "}"
            }.ToArray();
    }

    public class AzureAppServicePlanSkuGenerationStrategy : ISkuGenerationStrategy
    {
        public bool CanHandle(AzureSkuModel model) => model.AzureResourceSymbolicName == CoreConstants.SymbolicNames.AppServicePlan;

        public string[] Create(AzureSkuModel model)
            => new List<string>
            {

            }.ToArray();
    }

    public class AzureWebAppSkuGenerationStrategy : ISkuGenerationStrategy
    {
        public bool CanHandle(AzureSkuModel model) => model.AzureResourceSymbolicName == CoreConstants.SymbolicNames.WebApp;

        public string[] Create(AzureSkuModel model)
            => new List<string>
            {

            }.ToArray();
    }
}
