using Application.Common.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Application.Common.Results;

public class Result<T>
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public ErrorType? ErrorType { get; }
    public T? Value { get; }

    public string? ErrorMessage { get; }

    private Result(bool isSuccess, T? value, ErrorType? error, string? errorMessage)
    {
        IsSuccess = isSuccess;
        Value = value;
        ErrorType = error;
        ErrorMessage = errorMessage;
    }

    public static Result<T> Success(T value) => new(true, value, null, null);
    public static Result<T> Failure(ErrorType errorType, string? errorMessage = null) => new(false, default, errorType, errorMessage);
}
