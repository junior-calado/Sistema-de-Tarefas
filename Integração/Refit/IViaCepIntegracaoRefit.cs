using Refit;
using Sistema_de_Tarefas.Integração.Response;

namespace Sistema_de_Tarefas.Integração.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);
    }
}
