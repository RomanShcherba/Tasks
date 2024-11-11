using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// Cat
    /// </summary>
    public class Cat : Animal
    {
        /// <summary>
        /// Cat
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
        public Cat(string name, int age, string status): base(name, age, status) 
        {
            LegCount = 4;
            Species = "cat";
        }

        /// <summary>
        /// Introduce
        /// </summary>
        public override string Introduce()
        {
            return base.Introduce()+ " Meow meow!";
        }
    }
}
