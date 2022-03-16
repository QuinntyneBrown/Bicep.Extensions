﻿using Newtonsoft.Json.Linq;

namespace Bicep.Extensions.Core.Models
{
    public class AzureResourceModel
    {
        public string? SymbolicName { get; set; }
        public string? Name { get; set; }
        public string? InstanceUniqueName { get; set; }
        public string? Location { get; set; } = "resourceGroup().location";
        public string? Kind { get; set; }
        public AzureResourcePropertiesModel? Properties { get; set; }
        public AzureSkuModel? Sku { get; set; }
        public AzureResourceType? Type { get; set; }
        public List<AzureResourceDependencyModel> Dependencies { get; set; } = new();
    }
}
