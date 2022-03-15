namespace Bicep.Extensions.Core
{
    public interface ITenseConverter
    {
        string Convert(string value, bool pastTense = true);
    }
}
