using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public interface IAzureResourceGenerationStrategy
    {
        bool CanHandle(AzureResourceModel model);

        string[] Create(AzureResourceModel model);
    }
}
