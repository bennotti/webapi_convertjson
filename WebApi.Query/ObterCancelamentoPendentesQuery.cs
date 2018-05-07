namespace WebApi.Query
{
    public class ObterCancelamentoPendentesQuery : IQuery
    {
        public string PathModulo { get; }

        public ObterCancelamentoPendentesQuery(string pathModulo)
        {
            PathModulo = pathModulo;
        }
    }
}
