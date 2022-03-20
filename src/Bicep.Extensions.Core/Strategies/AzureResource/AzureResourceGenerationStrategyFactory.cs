using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies.AzureResource
{
    public class AzureResourceGenerationStrategyFactory : IAzureResourceGenerationStrategyFactory
    {
        private readonly List<IAzureResourceGenerationStrategy> _strategies;

        public AzureResourceGenerationStrategyFactory(
            )
        {
            _strategies = new List<IAzureResourceGenerationStrategy>()
            {

            };
        }
        public void CreateFor(AzureResourceModel model)
        {
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var strategy = _strategies.Where(x => x.CanHandle(model)).FirstOrDefault();

            if (strategy == null)
            {
                throw new InvalidOperationException("Cannot find a strategy for generation for the symbolic name " + model.SymbolicName);
            }

            strategy.Create(model);
        }
    }
}
