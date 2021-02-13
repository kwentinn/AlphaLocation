using MediatR;
using System.Threading.Tasks;

namespace AlphaLocation.Cqrs.Base.Queries
{
	public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
		where TQuery : IQuery<TResponse>
	{
		Task<TResponse> HandleAsync(TQuery query);
	}
}
