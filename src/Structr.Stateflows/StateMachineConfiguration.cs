using System.Threading;
using System.Threading.Tasks;

namespace Structr.Stateflows
{
    /// <summary>
    /// Serves as a base class for state machine configurations.
    /// </summary>
    /// <typeparam name="TEntity">Type of entity which behavior is modeled.</typeparam>
    /// <typeparam name="TState">Type of object describing entity states.</typeparam>
    /// <typeparam name="TTrigger">Type representing set of possible triggers.</typeparam>
    public abstract class StateMachineConfiguration<TEntity, TState, TTrigger> : IStateMachineConfiguration<TEntity, TState, TTrigger>
    {
        Task IStateMachineConfiguration<TEntity, TState, TTrigger>.ConfigureAsync(Stateless.StateMachine<TState, TTrigger> stateMachine,
            TEntity entity,
            CancellationToken cancellationToken)
        {
            Configure(stateMachine, entity);
            return Task.CompletedTask;
        }

        protected abstract void Configure(Stateless.StateMachine<TState, TTrigger> stateMachine, TEntity entity);
    }
}
