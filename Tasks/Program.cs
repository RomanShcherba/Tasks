using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        public static void Main(string[] args)
        {
            Shark shark = new("Sharp tooth", 20, "Old");
            Console.WriteLine(shark.Introduce());

            Cat cat = new("Lucky", 2, "Sleepy");
            Console.WriteLine(cat.Introduce());

            Dog dog = new("Bern", 5, "Excited", "John");
            Console.WriteLine(dog.Introduce());
            Console.WriteLine(dog.GreetMaster());

            Monkey monkey = new("Grunk", 7, "Eating banana");
            Console.WriteLine(monkey.Introduce());
        }
    }
}
