namespace ResultExtension;

/// <summary>
/// Result.
/// </summary>
/// <typeparam name="T">Type entity.</typeparam>
public class Result<T>
{
    public T? Value { get; init; }
    public bool IsSuccess { get; init; }
    public string Message { get; init; }
    public ResultType ResultType { get; init; }
    
    private Result(T value, bool isSuccess, string message, ResultType resultType)
    {
        Value = value;
        IsSuccess = isSuccess;
        Message = message;
        ResultType = resultType;
    }

    /// <summary>
    /// Failed result.
    /// </summary>
    /// <param name="message">Error message.</param>
    /// <param name="resultType"><see cref="ResultType"/>.</param>
    /// <returns><see cref="Result{T}"/>. Value = default.</returns>
    public static Result<T?> Failed(string message, ResultType resultType)
    {
        return new Result<T?>(default, false, message, resultType);
    }

    /// <summary>
    /// Success result.
    /// </summary>
    /// <param name="value">Entity.</param>
    /// <returns><see cref="Result{T}"/>.</returns>
    public static Result<T> Success(T value)
    {
        return new Result<T>(value, true, string.Empty, ResultType.Ok);
    }
}