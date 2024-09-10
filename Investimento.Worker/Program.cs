using Investimento.Worker;
using Investimento.Worker.Interfaces.Requisicoes;
using RestEase.HttpClientFactory;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddRestEaseClient<IBrapiRequest>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri(Environment.GetEnvironmentVariable("BASE_BARAPI"));
        c.DefaultRequestHeaders.Add("Accept", "application/json");
    });

var host = builder.Build();
host.Run();
