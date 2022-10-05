using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPython.Hosting;
using IronPython.Runtime;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var engine = Python.CreateEngine();

                var source = engine.CreateScriptSourceFromFile("mycode.py");

                var scope = engine.CreateScope();

                source.Execute(scope);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : ", ex.Message);
            }

            Console.Read();


        }
    }
}
