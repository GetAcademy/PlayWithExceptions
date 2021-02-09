using System;
using System.Collections.Generic;
using System.Text;

namespace PlayWithExceptions
{
    class RailwayorientedErrorHandlingDemo
    {
        public static Result Run(int n)
        {
            return Result.Ok(n)
                .OnSuccess(Step1)
                .OnSuccess(Step2);

            //try
            //{
            //    n = Step1(n);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}

            //try
            //{
            //    n = Step2(n);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    throw;
            //}

            //return n;
        }

        private static Result Step1(Result result)
        {
            if (result.Value == 0) return Result.Fail("no good");
            return Result.Ok(10 / result.Value);
        }

        private static Result Step2(Result result)
        {
            var n = result.Value + 10;
            if( n % 2 == 0) Result.Fail("no good");
            return Result.Ok(n);
        }

    }
}
