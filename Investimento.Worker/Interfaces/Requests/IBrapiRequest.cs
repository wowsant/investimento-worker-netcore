using RestEase;

namespace Investimento.Worker.Interfaces.Requisicoes;

[AllowAnyStatusCode]
public interface IBrapiRequest
{
    [Get("quote/PETR4?token=2rcexYMjzRtFX7vernzgmX")]
    Task<HttpResponseMessage> ObterCotacaoAsync();
}
