using System;
using System.Collections.Generic;
using System.Text;

namespace PlayWithExceptions
{
    class Result
    {
        public bool IsError { get; }
        public bool IsSuccess => !IsError;
        public string ErrorMessage { get; }
        public int Value { get; }

        public Result(bool isError, string errorMessage, int value)
        {
            Value = value;
            ErrorMessage = errorMessage;
            IsError = isError;
        }

        public static Result Ok(int value)
        {
            return new Result(false, null, value);
        }

        public static Result Fail(string errorMessage)
        {
            return new Result(true, errorMessage, -1);
        }

        public Result OnSuccess(Func<Result,Result> action)
        {
            if (IsError) return this;
            return action(this);
        }

        public Result OnFail(Func<Result, Result> action)
        {
            if (!IsError) return this;
            action(this);
            return this;
        }
    }
}
