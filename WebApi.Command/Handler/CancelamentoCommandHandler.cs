namespace WebApi.Command.Handler
{
    public class CancelamentoCommandHandler : AbstractCommandHandler<CancelamentoJsonCommand>
    {
        public CancelamentoCommandHandler(CancelamentoJsonCommand classReference, string pathModulo) 
            : base(classReference, pathModulo)
        {
        }
    }
}
