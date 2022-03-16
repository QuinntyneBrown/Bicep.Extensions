using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public interface IAzureStorageResourcePropertiesGenerationStrategyFactory
    {
        string[] CreateFor(AzureResourcePropertiesModel model);
    }
}
