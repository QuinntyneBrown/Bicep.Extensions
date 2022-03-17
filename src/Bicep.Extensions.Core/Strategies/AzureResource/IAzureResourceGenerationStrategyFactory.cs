using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies.AzureResource
{
    public interface IAzureResourceGenerationStrategyFactory
    {
        void CreateFor(AzureResourceModel model);
    }
}
