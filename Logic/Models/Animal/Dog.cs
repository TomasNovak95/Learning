using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models.Animal
{
    internal class Dog : Animal             // dědičnost = Pes je zvíře
    {
        private bool _isClever;

        public bool IsClever
        {
            get { return _isClever; }
        }

        public Dog(string name, bool _isClever)
            :base(4, name)
        {
            _isClever = IsClever;
        }
        public override void MakeNoise()            // override = přepíše původní metodů Make Noise, musí být virtual v té původní
        {
            Console.WriteLine("Woof");
        }
        public void TailSwing()
        {
            Console.WriteLine(Name + " is swinging with its tail");
        }
    }
}
