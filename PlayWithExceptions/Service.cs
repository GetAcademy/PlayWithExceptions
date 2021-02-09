using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PlayWithExceptions
{
    class Service
    {
        public static int GetByteCount(string url)
        {
            url = "https://" + url;
            Exception ex = null;
            var webClient = new WebClient();
            try
            {
                return webClient.DownloadString(url).Length;
            }
            catch (WebException e)
            {
                ex = e;
                throw new CouldntReadUrlException(url);
            }
            catch (NullReferenceException e)
            {
                ex = e;
                throw new CouldntReadUrlException(url);
            }
            catch (Exception e)
            {
                ex = e;
                throw new UnknownApplicationException(e);
            }
            finally
            {

            }
        }
    }
}
