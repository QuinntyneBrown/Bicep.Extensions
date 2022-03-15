using Bicep.Extensions.Core;
using CommandLine;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Bicep.Extensions.Application
{
    public class Default
    {
        [Verb("default")]
        internal class Request : IRequest<Unit> {
            
            [Option('n',"name")]
            public string Name { get; set; }

            [Option('d', Required = false)]
            public string Directory { get; set; } = Environment.CurrentDirectory;
        }

        internal class Handler : IRequestHandler<Request, Unit>
        {
            private readonly ILogger _logger;
            private readonly IFileFactory _fileFactory;
            private readonly IFileGenerationStrategy _fileGenerationStrategy;

            public Handler(ILogger logger, IFileFactory fileFactory, IFileGenerationStrategy fileGenerationStrategy)
            {
                _logger = logger ?? throw new ArgumentNullException(nameof(logger));
                _fileFactory = fileFactory ?? throw new ArgumentNullException(nameof(fileFactory));
                _fileGenerationStrategy = fileGenerationStrategy ?? throw new ArgumentNullException(nameof(fileGenerationStrategy));
            }

            public async Task<Unit> Handle(Request request, CancellationToken cancellationToken)
            {
                _logger.LogInformation($"Handled: {nameof(Default)}");

                var model = _fileFactory.CreateBicep("Default", request.Name, request.Directory);
                return new();
            }
        }
    }
}
