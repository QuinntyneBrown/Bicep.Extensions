using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public interface ISkuGenerationStrategy
    {
        bool CanHandle(AzureSkuModel model);
        string[] Create(AzureSkuModel model);
    }
}
