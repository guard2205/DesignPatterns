using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Solid;
namespace DesignPatterns
{
    public class Program
    {
        static void Main(string[] args)
        {
            var j = new Journal();
            j.AddEntry("I wake up");
            j.AddEntry("I lunched");
            Console.WriteLine(j.ToString());

            Console.WriteLine("Enter a key");
            Console.ReadKey();
        }
    }
}
