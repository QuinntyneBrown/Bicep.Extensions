using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Bicep.Extensions.Core;
using Bicep.Extensions.Core.Factories;
using Bicep.Extensions.Core.Strategies;

namespace Bicep.Extensions.Cli
{
    public class Dependencies
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddMediatR(typeof(Bicep.Extensions.Application.Default));

            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<Program>(optional:true)
                .Build();

            services.AddSingleton<IConfiguration>(_ => configuration);

            services.AddSingleton<ICommandService, CommandService>();
            services.AddSingleton<IFileSystem, FileSystem>();
            services.AddSingleton<ITemplateLocator, TemplateLocator>();
            services.AddSingleton<ITemplateProcessor, LiquidTemplateProcessor>();
            services.AddSingleton<INamingConventionConverter, NamingConventionConverter>();
            services.AddSingleton<ITenseConverter, TenseConverter>();
            services.AddSingleton<INamespaceProvider, NamespaceProvider>();
            services.AddSingleton<IFileProvider, FileProvider>();
            services.AddSingleton<IFileFactory,FileFactory>();
            services.AddSingleton<IFileGenerationStrategy,FileGenerationStrategy>();
            services.AddSingleton<IBicepTemplateFactory, BicepTemplateFactory>();
            services.AddSingleton<IAzureResourceFactory, AzureResourceFactory>();
            services.AddSingleton<IBicepTemplateGenerationStrategy, BicepTemplateGenerationStrategy>();
            services.AddSingleton(CreateLoggerFactory().CreateLogger("cli"));
            
        }

        private static ILoggerFactory CreateLoggerFactory()
        {
            return LoggerFactory.Create(builder =>
            {
                builder.AddProvider(new LoggerProvider(new LoggerOptions(true, ConsoleColor.Red, ConsoleColor.DarkYellow, Console.Out)));
            });
        }
    }
}
