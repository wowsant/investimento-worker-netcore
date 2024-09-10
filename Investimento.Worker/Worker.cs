using Investimento.Worker.Interfaces.Requisicoes;
using Investimento.Worker.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Investimento.Worker;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IBrapiRequest _brapiRequest;

    public Worker(ILogger<Worker> logger, IBrapiRequest brapiRequest)
    {
        _logger = logger;
        _brapiRequest = brapiRequest;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            }

            var httpResponseMessage = await _brapiRequest.ObterCotacaoAsync();
            Console.WriteLine(httpResponseMessage.StatusCode);

            var sant = JsonConvert.DeserializeObject<CotacaoModel>(await httpResponseMessage.Content.ReadAsStringAsync())!;
            Console.WriteLine(sant);
            await Task.Delay(1000, stoppingToken);
        }
    }
}
