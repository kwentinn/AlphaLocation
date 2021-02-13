using System.Threading;
using System.Threading.Tasks;

namespace AlphaLocation.Cqrs.Base.Queries
{
	public abstract class QueryHandler<TQuery, TResponse> : IQueryHandler<TQuery, TResponse>
		where TQuery : IQuery<TResponse>
	{
		public abstract Task<TResponse> HandleAsync(TQuery query);

		public Task<TResponse> Handle(TQuery query, CancellationToken cancellationToken)
		{
			return this.HandleAsync(query);
		}
	}
}
