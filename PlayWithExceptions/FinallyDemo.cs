using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlayWithExceptions
{
    class FinallyDemo
    {
        static int i = 1;
        public static int Test()
        {
      
            try
            {
                DoSomething();
                return i;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return -1;
            }
            finally
            {
                i++;
                Console.WriteLine("Ferdig");
            }
        }

        async static Task DoSomething()
        {
            i++;
        }
    }
}
