namespace WebApi.Query.Result
{
    public class ObterCancelamentoPendentesQueryResult : IQueryResult
    {
        public string Cpf { get; }
        public string NumeroAvaliacao { get; }

        public ObterCancelamentoPendentesQueryResult(string cpf, string numeroAvaliacao)
        {
            Cpf = cpf;
            NumeroAvaliacao = numeroAvaliacao;
        }
    }
}
