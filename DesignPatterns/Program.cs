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
            Console.WriteLine("SolidSRP");
            j.AddEntry("I wake up");
            j.AddEntry("I lunched");
            Console.WriteLine(j.ToString());
            Console.WriteLine("===========\n SolidORP");
            Console.WriteLine("*Filtering Without SOLIDORP*");
            var apple = new Product("Appel", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };
            var pf = new ProductFilter();

            Console.WriteLine("Green products (old): ");
            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($" - {p.Name} is green");
            }

            Console.WriteLine("*Filtering With SOLIDORP*");
            var bf = new BetterFilter();
            Console.WriteLine("Green products (new): ");
            foreach( var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($" - {p.Name} is green");
            }
            Console.WriteLine("Large blue items");
            foreach(var p in bf.Filter(products, new AndSpecification<Product>( new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - {p.Name} is blue and big");
            }
            Console.WriteLine("===========\n SolidORP");

            Console.WriteLine("Enter a key");
            Console.ReadKey();
        }
    }
}
