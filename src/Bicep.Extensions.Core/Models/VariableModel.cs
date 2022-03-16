namespace Bicep.Extensions.Core.Models
{
    public class VariableModel
    {
        public string? Name { get; set; }
        public string? Value { get; set; }
        public VariableModel(string name)
        {
            Name = name;
        }

        public VariableModel()
        {

        }
    }
}
