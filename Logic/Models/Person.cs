using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    internal class Person
    {
        public string FirstName { get; set; }  //prop + dvakrát tab
        public string LastName { get; set; }
        /// <summary>
        /// Napsáním 3 lomítek se propíše poznámka, Tohle je věk
        /// </summary>
        public int Age { get; set; }
        public double Height { get; set; }      // musí být .0
        public decimal? Weight { get; set; }        //? - nullable - není nutné zadat

        public void Walk()
        {
            Console.WriteLine(FirstName + " is walking..");
        }



    }
}
