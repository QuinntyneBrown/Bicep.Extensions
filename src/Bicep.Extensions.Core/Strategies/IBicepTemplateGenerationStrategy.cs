using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{
    public interface IBicepTemplateGenerationStrategy
    {
        bool CanHandle(BicepTemplateModel model);
        void Create(BicepTemplateModel model);
    }
}
