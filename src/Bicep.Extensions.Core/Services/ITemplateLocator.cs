namespace Bicep.Extensions.Core
{
    public interface ITemplateLocator
    {
        string[] Get(string filename);
    }
}
