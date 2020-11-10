using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace D___En_Webside
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestManager manager = new RequestManager();
            Console.WriteLine("Type (1) for requesting using web request\n" +
                              "Type (2) for requesting using file request");
            int input = int.Parse(Console.ReadLine());
            if (input == 1)
            {
                Console.Clear();
                Console.WriteLine("Please type the URL you want to use for requesting. (Note that 'https://')");
                string urlInput = Console.ReadLine();
                
                Console.WriteLine(manager.MakeWebRequest(urlInput));
            }
            else if (input == 2)
            {
                Console.Clear();
                Console.WriteLine("Please type the path you want to read a file from");
                string fileInput = Console.ReadLine();
                Console.WriteLine(manager.MakeFileRequest(fileInput));
            }
            else
            {
                Console.WriteLine("Something went wrong. Try again");
            }

            // Close the response.
            Console.ReadLine();
        }
    }
}
