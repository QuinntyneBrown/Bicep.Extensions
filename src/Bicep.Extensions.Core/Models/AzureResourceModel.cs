namespace Bicep.Extensions.Core.Models
{
    public class AzureResourceModel
    {
        public string? SymbolicName { get; set; }
        public string? Name { get; set; }
        public string? UniqueName => Name + "${uniqueString(resourceGroup().id)}";
        public string? Location { get; set; } = "resourceGroup().location";
        public string? Kind { get; set; }
        public AzureResourcePropertiesModel? Properties { get; set; }
        public AzureSkuModel? Sku { get; set; }
        public AzureResourceType? Type { get; set; }
        public List<AzureResourceDependencyModel> Dependencies { get; set; } = new();
    }
}
