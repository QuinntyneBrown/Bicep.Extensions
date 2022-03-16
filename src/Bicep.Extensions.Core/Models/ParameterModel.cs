namespace Bicep.Extensions.Core.Models
{
    public class ParameterModel
    {
        public ParameterDecoratorModel Decorator { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Value { get; set; }
        public ParameterModel()
        {

        }
    }
}
