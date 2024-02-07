using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TradingEngineServer.core
{
     interface ITradingEngineServer
    {
        Task Run(CancellationToken token);
    }
}
