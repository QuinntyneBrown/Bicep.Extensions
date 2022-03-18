namespace Bicep.Extensions.Core.Models
{
    public class ParameterModel
    {
        public List<ParameterDecoratorModel> Decorators { get; set; } = new();
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Value { get; set; }
        public ParameterModel()
        {

        }
    }
}
