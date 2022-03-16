using Newtonsoft.Json.Linq;

namespace Bicep.Extensions.Core.Models
{
    public class AzureResourcePropertiesModel: JObject
    {
        public string? AzureResourceSymbolicName { get; set; }

        public AzureResourcePropertiesModel(string azureResourceSymbolicName, JObject other)
            :base(other)
        {
            AzureResourceSymbolicName = azureResourceSymbolicName;
        }

        public static AzureResourcePropertiesModel Parse(string azureResourceSymbolicName, string json)
        {
            var jobject = JObject.Parse(json);

            return new AzureResourcePropertiesModel(azureResourceSymbolicName, jobject);
        }
    }
}
