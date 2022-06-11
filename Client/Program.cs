using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lastInfo = null;
            string currentMessage = null;
            WebClient webClient = new WebClient();
            while(true)
            {
                webClient.DownloadFile("http://localhost:8000/", @"C:\test\info.txt");
                currentMessage = File.ReadAllText(@"C:\test\info.txt");
                if (lastInfo == currentMessage)
                {
                }
                else
                {
                    Console.WriteLine(currentMessage);
                    Console.WriteLine("");
                    Console.WriteLine("");
                }
                lastInfo = currentMessage;
                File.Delete(@"C:\test\info.txt");
            }
        }
    }
}
