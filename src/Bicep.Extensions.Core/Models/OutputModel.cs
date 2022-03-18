namespace Bicep.Extensions.Core.Models
{

    public class OutputModel
    {
        public string? Name { get; set; }
        public string? Value { get; set; }
        public OutputType OutputType { get; set; } = OutputType.Varirable;
        public OutputModel(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public OutputModel(string name, string value, OutputType outputType)
            :this(name,value)
        {
            OutputType = outputType;
        }

    }
}
