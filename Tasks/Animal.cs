using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    /// <summary>
    /// Animal
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Leg count
        /// </summary>
        public int LegCount {  get; set; }

        /// <summary>
        /// Arm count
        /// </summary>
        public int ArmCount { get; set; }

        /// <summary>
        /// Species
        /// </summary>
        public string Species { get; set; }

        /// <summary>
        /// Animal
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
        public Animal(string name, int age, string status)
        {
            Name = name;
            Age = age;
            Status = status;
        }

        /// <summary>
        /// Introduce
        /// </summary>
        public virtual string Introduce()
        {
            return $"Hi my name is {Name} and my age is {Age} years";
        }
    }
}
