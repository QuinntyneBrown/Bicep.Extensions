using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies.AzureResource
{
    public interface IAzureResourceGenerationStrategyFactory
    {
        void CreateFor(AzureResourceModel model);
    }
    public class AzureResourceGenerationStrategyFactory : IAzureResourceGenerationStrategyFactory
    {
        public void CreateFor(AzureResourceModel model)
        {
            throw new NotImplementedException();
        }
    }
}
