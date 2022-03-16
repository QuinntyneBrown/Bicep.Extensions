namespace Bicep.Extensions.Core.Models
{
    public class ParameterDecoratorModel
    {
        public string Name { get; set; }
    }

    public class AllowedParameterDecoratorModel: ParameterDecoratorModel
    {
        public string[] Values { get; set; }
    }
}
