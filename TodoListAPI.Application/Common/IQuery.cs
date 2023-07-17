using MediatR;
using TodoListAPI.Domain.Common;

namespace TodoListAPI.Application.Common;

public interface IQuery<TRequest> : IRequest<Result<TRequest>>
{
}

public interface IQuery : IRequest<Result>
{
}
