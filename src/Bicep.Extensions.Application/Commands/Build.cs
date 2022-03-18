using Bicep.Extensions.Core;
using CommandLine;
using MediatR;
using Microsoft.Extensions.Logging;


namespace Bicep.Extensions.Application.Commands
{
    internal class Build
    {
        [Verb("build")]
        internal class Request : IRequest<Unit> {
            [Value(0)]
            public string? File { get; set; }
            [Option('d', Required = false)]
            public string Directory { get; set; } = Environment.CurrentDirectory;
        }

        internal class Handler : IRequestHandler<Request, Unit>
        {
            private readonly ILogger _logger;
            private readonly ICommandService _commandService;

            public Handler(ILogger logger, ICommandService commandService)
            {
                _logger = logger ?? throw new ArgumentNullException(nameof(logger));
                _commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));
            }

            public async Task<Unit> Handle(Request request, CancellationToken cancellationToken)
            {
                _logger.LogInformation($"Handled: {nameof(Build)}");

                _commandService.Start($"az bicep build --file {request.File}", request.Directory);

                return new();
            }
        }
    }
}
