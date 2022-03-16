namespace Bicep.Extensions.Core.Models
{
    public class BicepTemplateModel
    {
        public List<AzureResourceModel> Resources { get; init; }
        public List<ParameterModel> Params { get; init; }
        public List<VariableModel> Variables { get; init; }
        public string Directory { get; set; }
        public BicepTemplateModel()
        {

        }
    }
}
