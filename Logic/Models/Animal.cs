using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    internal class Animal
    {

        //          Fields      //
        private int _numberOfLegs;
        private string _name;
        /// <summary>
        /// Construktor
        /// </summary>
        /// <param name="numberOfLegs">Počet nohou</param>
        //      Construktor     //
        public Animal(int numberOfLegs) //ctor double tab vytvoří konstrukto
        {
            _numberOfLegs = numberOfLegs;
        }
        public Animal(int numberOfLegs, string name)
            : this(numberOfLegs)            //volá Constructor, který má stejný argument
        {
            _name = name;
            
        }
        //      Properties      //
        public int NumberOfLegs
        {
            get { return _numberOfLegs; }

        }
        public string Name
        {
            get { return _name; }
            
        }


    }
}
