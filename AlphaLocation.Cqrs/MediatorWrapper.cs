using AlphaLocation.Cqrs.Base.Commands;
using AlphaLocation.Cqrs.Base.Queries;
using MediatR;
using System.Threading.Tasks;

namespace AlphaLocation.Cqrs
{
	/// <inheritdoc/>
	public class MediatorWrapper : IMediatorWrapper
	{
		private readonly IMediator mediator;

		public MediatorWrapper(IMediator mediator)
		{
			this.mediator = mediator;
		}

		/// <inheritdoc/>
		public async Task DispatchAsync(ICommand command)
		{
			await this.mediator.Send(command);
		}

		/// <inheritdoc/>
		public async Task<TResult> DispatchAsync<TResult>(ICommand<TResult> command)
		{
			return await this.mediator.Send(command);
		}

		/// <inheritdoc/>
		public async Task<TResponse> GetResultAsync<TResponse>(IQuery<TResponse> query)
		{
			return await this.mediator.Send(query);
		}
	}
}
