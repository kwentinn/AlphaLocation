using AlphaLocation.Cqrs.Base.Commands;
using AlphaLocation.Cqrs.Base.Queries;
using System.Threading.Tasks;

namespace AlphaLocation.Cqrs
{
	/// <summary>
	/// Wraps the underlying mediator pattern provider.
	/// </summary>
	public interface IMediatorWrapper
	{
		/// <summary>
		/// Dispatch any command of type <see cref="ICommand"/>
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		Task DispatchAsync(ICommand command);

		/// <summary>
		/// Dispatch any command of type <see cref="ICommand"/>
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		Task<TResult> DispatchAsync<TResult>(ICommand<TResult> command);

		/// <summary>
		/// Gets a result from a query.
		/// </summary>
		/// <typeparam name="TResponse"></typeparam>
		/// <param name="query"></param>
		/// <returns></returns>
		Task<TResponse> GetResultAsync<TResponse>(IQuery<TResponse> query);
	}
}
