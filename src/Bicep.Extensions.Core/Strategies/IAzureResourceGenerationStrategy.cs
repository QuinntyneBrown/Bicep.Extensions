using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public interface IAzureResourceGenerationStrategy
    {
        string[] Create(AzureResourceModel model);
    }
}
