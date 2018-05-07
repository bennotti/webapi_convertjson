namespace WebApi.Command.Handler
{
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Handler();
    }

    public interface ICommandHandler<in TCommand, out TQueryResult> where TCommand : ICommand
    {
        TQueryResult Handler();
    }
}
