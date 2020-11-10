using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace D___En_Webside
{
    public class FileRequest : IRequest
    {
        private string request;
        public string Request(string url)
        {
            request = System.IO.File.ReadAllText(url);
            return request;
        }
    }
}
