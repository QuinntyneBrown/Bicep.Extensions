namespace Bicep.Extensions.Core
{
    public interface IFileFactory
    {
        FileModel Create(string template, string name, string directory, string extension);
        FileModel CreateBicep(string template, string name, string directory);
    }
}
