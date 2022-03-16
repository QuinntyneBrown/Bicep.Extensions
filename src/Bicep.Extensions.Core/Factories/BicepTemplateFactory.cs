using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Factories
{
    public class BicepTemplateFactory: IBicepTemplateFactory
    {
        public BicepTemplateModel Create(string symbolicName, string name, string verison)
        {
            var model = new BicepTemplateModel();

            model.Resources.Add(new AzureResourceModel()
            {
                SymbolicName = symbolicName,
                Name = "",
                Type = new AzureResourceType()
                {
                    Name = name,
                    Version = verison
                }
            });

            return model;
        }

        public BicepTemplateModel CreateStorageAccount()
            => Create(
                "storageAccount", 
                "Microsoft.Storage/storageAccounts", 
                "2021-08-01");
    }
}
