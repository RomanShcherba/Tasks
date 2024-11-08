using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// Shark
    /// </summary>
    public class Shark : Animal
    {
        /// <summary>
        /// Shark
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
        public Shark(string name, int age, string status) : base(name, age, status)
        {
            LegCount = 0;
            Species = "Shark";
        }

        /// <summary>
        /// Introduce
        /// </summary>
        public override string Introduce()
        {
            return base.Introduce()+ " Blup blup";
        }
    }
}
