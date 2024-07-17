using Sistema_de_Tarefas.Integração.Response;

namespace Sistema_de_Tarefas.Integração.Interfaces
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);
    }
}
