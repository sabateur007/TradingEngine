using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;
using TradingEngineServer.core.Configurations;


namespace TradingEngineServer.core
{
    sealed class TradingEngineServer : BackgroundService, ITradingEngineServer
    {
        private readonly ILogger<TradingEngineServer> _logger;
        private readonly TradingEngineServerConfigurations _configuration;
        public TradingEngineServer(ILogger<TradingEngineServer> logger,IOptions<TradingEngineServerConfigurations> config) 
        { 
            _logger = logger?? throw new ArgumentNullException(nameof(logger));
            _configuration = config.Value ?? throw new ArgumentNullException(nameof(config)) ;  // "??" is called nul coaleaase opertaor
        }

        public Task Run(CancellationToken token) => ExecuteAsync(token);
        

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
           while(stoppingToken.IsCancellationRequested)
            { }
           return Task.CompletedTask;
        }
    }
}
