using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies.AzureResource
{
    public interface IAzureResourceGenerationStrategyFactory
    {
        string[] CreateFor(AzureResourceModel model);
    }
}
