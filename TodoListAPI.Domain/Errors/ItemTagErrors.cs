using System.Net;
using TodoListAPI.Domain.Common;

namespace TodoListAPI.Domain.Errors;

public static class ItemTagErrors
{
    public static Error NotFound(Guid id) => new($"ItemTag with id {id} was not found.", HttpStatusCode.NotFound);

    public static Error AlreadyExists(string name) => new($"ItemTag with name {name} already exists.", HttpStatusCode.Conflict);
}
