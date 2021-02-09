using System;
using System.Net;

namespace PlayWithExceptions
{
    class Program
    {
        // 1: Unngå exception, type sjekk != null
        // 2: Exceptions vi ikke kan unngå
        // 3: Lage egne exceptions
        // 4: Unngå exceptions

        // Refactoring
        // OLID

        static void Main(string[] args)
        {
            Console.WriteLine(RailwayorientedErrorHandlingDemo.Run(5));
            return;


            try
            {
                var byteCount = Service.GetByteCount("hkh");
            }
            catch (CouldntReadUrlException crue)
            {
                Console.WriteLine("Ugyldig url: " + crue.Url);
            }

            return;
            var url = "https://" + args[0];

            var webClient = new WebClient();
            var bytes = "";
            try
            {
                bytes = webClient.DownloadString(url);
            }
            catch (WebException e)
            {
                Console.WriteLine(e.ToString());
                bytes = "Feil";
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                bytes = "Feil";
            }
            finally
            {

            }

            Console.WriteLine(bytes);

            //Console.WriteLine(args.Length >= 1 ? $"Hei, {args[0]}!" : $"Hei!");
            //Console.WriteLine($"Hei, {args[0]}!");
            //Console.WriteLine("Making diamonds");

        }
    }
}
