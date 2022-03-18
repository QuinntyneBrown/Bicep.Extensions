namespace Bicep.Extensions.Core.Models
{
    public class BicepTemplateModel
    {
        public List<AzureResourceModel> Resources { get; init; } = new();
        public List<ParameterModel> Params { get; init; } = new();
        public List<VariableModel> Variables { get; init; } = new();
        public List<ConfigurationMapModel> ConfigurationMaps { get; init; } = new();
        public string? Directory { get; set; }
        public BicepTemplateModel()
        {

        }
    }
}
