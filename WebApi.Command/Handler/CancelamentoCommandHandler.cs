namespace WebApi.Command.Handler
{
    public class CancelamentoCommandHandler : AbstractCommandHandler<CancelamentoJsonComand>
    {
        public CancelamentoCommandHandler(CancelamentoJsonComand classReference, string pathModulo) 
            : base(classReference, pathModulo)
        {
        }
    }
}
