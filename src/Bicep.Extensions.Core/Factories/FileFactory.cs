namespace Bicep.Extensions.Core
{

    public class FileFactory: IFileFactory
    {
        public FileModel Create(string template, string name, string directory, string extension)
            => new()
            {
                Extension = extension,
                Directory = directory,
                Template = template,
                Name=name
            };

        public FileModel CreateBicep(string template, string name, string directory)
            => Create(template, name, directory, "bicep");
    }
}
