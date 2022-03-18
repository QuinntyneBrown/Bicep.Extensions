using Microsoft.Extensions.Logging;

namespace Bicep.Extensions.Cli
{
    public class LoggerProvider : ILoggerProvider
    {
        private readonly LoggerOptions _options;

        public LoggerProvider(LoggerOptions options)
        {
            _options = options;
        }

        public void Dispose() { }

        public ILogger CreateLogger(string categoryName)
        {
            return new ConsoleLogger(_options);
        }
    }
}
