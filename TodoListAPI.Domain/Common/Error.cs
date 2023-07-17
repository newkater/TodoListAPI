using System.Net;

namespace TodoListAPI.Domain.Common;

public record Error (string Message, HttpStatusCode StatusCode);
