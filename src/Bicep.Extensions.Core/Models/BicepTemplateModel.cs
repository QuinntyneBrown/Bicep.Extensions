namespace Bicep.Extensions.Core.Models
{
    public class BicepTemplateModel
    {
        public List<AzureResourceModel> Resources { get; init; }
        public string Directory { get; set; }
        public BicepTemplateModel()
        {

        }
    }
}
