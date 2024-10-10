using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// Dog
    /// </summary>
    public class Dog : Animal 
    {
        /// <summary>
        /// Master
        /// </summary>
        public string Master { get; set; }

        /// <summary>
        /// Dog
        /// </summary>
        /// <param name="name">
        /// Name
        /// </param>
        /// <param name="age">
        /// Age
        /// </param>
        /// <param name="status">
        /// Status
        /// </param>
        /// <param name="master">
        /// Master
        /// </param>
        public Dog(string name, int age, string status, string master): base(name, age, status)
        {
            LegCount = 4;
            Species = "Dog";
            Master = master;
        }

        /// <summary>
        /// Introduce
        /// </summary>
        public override string Introduce()
        {
            return base.Introduce();
        }

        /// <summary>
        /// Greet master
        /// </summary>
        public string GreetMaster()
        {
            return $"Hello {Master}";
        }
    }
}
