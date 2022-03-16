using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{

    public class BicepTemplateGenerationStrategy: IBicepTemplateGenerationStrategy
    {
        private readonly IFileSystem _fileSystem;
        public BicepTemplateGenerationStrategy(IFileSystem fileSystem)
        {
            _fileSystem = fileSystem;
        }

        public bool CanHandle(BicepTemplateModel model) => true;

        public void Create(BicepTemplateModel model)
        {
            _fileSystem.WriteAllLines($"{model.Directory}{Path.DirectorySeparatorChar}main.bicep", default);
        }
    }
}
