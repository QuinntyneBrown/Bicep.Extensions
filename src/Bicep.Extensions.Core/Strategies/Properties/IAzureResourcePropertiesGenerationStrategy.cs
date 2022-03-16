using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public interface IAzureResourcePropertiesGenerationStrategy
    {
        bool CanHandle(AzureResourcePropertiesModel model);

        string[] Create(AzureResourcePropertiesModel model);
    }
}
