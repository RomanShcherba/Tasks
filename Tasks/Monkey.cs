using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// Monkey
    /// </summary>
    public class Monkey : Animal
    {
        /// <summary>
        /// Monkey
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
        public Monkey(string name, int age, string status) : base(name, age, status)
        {
            LegCount = 2;
            ArmCount = 2;
            Species = "Monkey"; 
        }

        /// <summary>
        /// Introduce
        /// </summary>
        public override string Introduce()
        {
            return base.Introduce() + " Wuhuhahaahahaha";
        }
    }
}
