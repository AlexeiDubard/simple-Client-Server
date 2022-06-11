using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ServerModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input;
            while(true)
            {
                Console.Write("> ");
                Input = Console.ReadLine();
                File.WriteAllText(@"C:\test\index.html", Input);
                Console.WriteLine("");
            }
        }
    }
}
