namespace WebApi.Command.Handler
{
    public interface ICommandHandler<ICommandQuery>
    {
        void Handler();
    }

    public interface ICommandHandler<in TCommandQuery, out TQueryResult>
    {
        TQueryResult Handler();
    }
}
