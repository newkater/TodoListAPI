using System.Net;
using TodoListAPI.Domain.Common;

namespace TodoListAPI.Domain.Errors;

public static class ItemCategoryErrors
{
    public static Error NotFound(Guid id) => new($"ItemCategory with id {id} was not found.", HttpStatusCode.NotFound);

    public static Error AlreadyExists(string name) => new($"ItemCategory with name {name} already exists.", HttpStatusCode.Conflict);
}
