namespace Bicep.Extensions.Core
{
    public partial class FileModel
    {
        public string? Template { get; init; }
        public string? Name { get; init; }
        public string? Directory { get; init; }
        public string? Extension { get; init; }
        public string? Path => $"{Directory}{System.IO.Path.DirectorySeparatorChar}{Name}.{Extension}";
        public Dictionary<string, object>? Tokens { get; init; }

        public FileModel()
        {

        }
    }
}
