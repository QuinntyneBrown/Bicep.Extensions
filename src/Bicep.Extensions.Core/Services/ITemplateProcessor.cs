using System.Collections.Generic;

namespace Bicep.Extensions.Core
{
    public interface ITemplateProcessor
    {
        string[] Process(string[] template, IDictionary<string, object> tokens, string[] ignoreTokens = null);
        string Process(string template, IDictionary<string, object> tokens);
    }
}
