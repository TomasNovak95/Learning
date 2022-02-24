using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models.Animal
{
    internal class Animal  // internal abstract class Animal  = není možné vytvořit base class  např. Animal universalAnimal = new Animal();
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

        //      Methods     //
        public virtual void MakeNoise()                 //virtual = možné přepsáná třídami, které z ní dědí
        {
            Console.WriteLine("Making noise..");
        }

    }
}
