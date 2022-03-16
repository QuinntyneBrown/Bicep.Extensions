using Bicep.Extensions.Core.Models;

namespace Bicep.Extensions.Core.Strategies
{

    public class AzureResourceGenerationStrategy : IAzureResourceGenerationStrategy
    {
        public string[] Create(AzureResourceModel model)
        {
            List<string> content = new List<string>();

            content.Add($"resource {model.SymbolicName} '{model.Type.Name}@{model.Type.Version}' =" + " {");
            content.Add("}");


            return content.ToArray();
        }
    }
}
