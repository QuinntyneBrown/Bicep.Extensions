namespace Bicep.Extensions.Core.Models
{
    public class ModuleModel
    {
        public string? Name { get; set; }
        public string? FileName { get; set; }
        public string? Scope { get; set; }
        public List<AzureResourceModel> Resources { get; set; } = new();
        public List<OutputModel> Outputs { get; set; } = new();
        public List<ConfigurationMapModel> ConfigurationMaps { get; set; } = new();
        public ModuleModel(string name, string fileName)
        {
            Name = name;
            FileName = fileName;
        }
    }
}
