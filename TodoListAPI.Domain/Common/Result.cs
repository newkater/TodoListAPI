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
