namespace TodoListAPI.Domain.Common;

public class Result<TResult>
{
    private readonly List<Error> _errors = new();
    public TResult? Value { get; init; }

    public Result(TResult? value)
    {
        Value = value;
        IsSuccess = true;
    }

    public IReadOnlyCollection<Error> Errors => _errors;

    public Result(IEnumerable<Error> errors)
    {
        _errors.AddRange(errors);
        IsSuccess = false;
    }

    public Result(Error error)
    {
        _errors.Add(error);
        IsSuccess = false;
    }

    public bool IsSuccess { get; private set; } = true;

    public bool IsError => !IsSuccess;

    public T Switch<T> (Func<TResult, T> onSuccess, Func<IEnumerable<Error>, T> onError)
    {
        if (IsError || Value is null) 
        {
            return onError(_errors);
        }
        else
        {
            return onSuccess(Value);
        }
    }

    public static implicit operator Result<TResult> (TResult value) => new Result<TResult>(value);

    public static implicit operator Result<TResult>(List<Error> errors) => new Result<TResult>(errors);

    public static implicit operator Result<TResult>(Error error) => new Result<TResult>(error);

}

public class Result
{
    private readonly List<Error> _errors = new();

    public Result()
    {
        IsSuccess = true;
    }

    public IReadOnlyCollection<Error> Errors => _errors;

    public Result(IEnumerable<Error> errors)
    {
        _errors.AddRange(errors);
        IsSuccess = false;
    }

    public Result(Error error)
    {
        _errors.Add(error);
        IsSuccess = false;
    }

    public bool IsSuccess { get; private set; } = true;

    public bool IsError => !IsSuccess;
}
