using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.core
{
    public sealed class TradingEngineServerHostBuilder
    {
        public static IHost BuildTradingEngineServer() => Host.CreateDefaultBuilder().ConfigureServices((Context, services) =>
        {
            //start with configurations


        }).Build();
    }
}
