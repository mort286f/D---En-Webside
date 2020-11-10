using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D___En_Webside
{
    class RequestManager
    {
        IRequest request;
        public string MakeWebRequest(string path)
        {
            request = new WebsideRequest();
            return request.Request(path);
        }

        public string MakeFileRequest(string path)
        {
            request = new FileRequest();
            return request.Request(path);
        }
    }
}
