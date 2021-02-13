using MediatR;

namespace AlphaLocation.Cqrs.Base.Queries
{
	public interface IQuery<TResponse> : IRequest<TResponse>
	{
	}
}
