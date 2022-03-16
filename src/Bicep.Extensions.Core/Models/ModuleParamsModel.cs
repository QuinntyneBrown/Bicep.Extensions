using Newtonsoft.Json.Linq;

namespace Bicep.Extensions.Core.Models
{
    public class ModuleParamsModel: JObject
    {
        public string ModuleName { get; set; }
        public ModuleParamsModel(string moduleName, JObject other)
            :base(other)
        {
            ModuleName = moduleName;
        }

        public static AzureResourcePropertiesModel Parse(string moduleName, string json)
        {
            var jobject = JObject.Parse(json);

            return new AzureResourcePropertiesModel(moduleName, jobject);
        }
    }
}
