using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace D___En_Webside
{
    public class WebsideRequest : IRequest
    {
        public WebRequest request;
        public WebResponse response;
        public string Request(string url)
        {
            request = WebRequest.Create("https://" + url);
            request.Credentials = CredentialCache.DefaultCredentials;
            response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);

                string responseFromServer = reader.ReadToEnd();
                response.Close();

                return responseFromServer;
            }
        }
    }
}
