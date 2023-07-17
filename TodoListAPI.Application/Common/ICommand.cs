using MediatR;
using TodoListAPI.Domain.Common;

namespace TodoListAPI.Application.Common;

public interface ICommand<TRequest> : IRequest<Result<TRequest>>
{
}

public interface ICommand : IRequest<Result>
{
}
