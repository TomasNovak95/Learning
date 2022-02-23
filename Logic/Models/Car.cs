using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    internal class Car
    {
        private int _numberOfHorns = 0;

        //Methods
        /// <summary>
        /// Zatroubí jednou
        /// </summary>
        internal void Horn()                            // třída má metody
        {
            Console.WriteLine("Car is horning!");
            _numberOfHorns++;
        }
        /// <summary>
        /// Zatroubí kolikrát chceš
        /// </summary>
        /// <param name="numberOfHorns">Počet zatroubení</param>
        internal void Horn(int numberOfHorns)                            // jmenuje se stejně, ale jsou jiné argumenty, program zvolí tu podle argumentů
        {
            Console.WriteLine("Car is horning!");
            _numberOfHorns+= numberOfHorns;
            for (int i = 0; i < numberOfHorns; i++)
            {
                Console.WriteLine("Car is horning");

            }
           // += přičte hodnotu argumentu
        }

        // Field
        private string _mark;
        #region OldWay
        // Setter
        internal void SetMark(string mark)
        {
            _mark = mark;
        }

        // Getter
        internal string GetMark()
        {
            return _mark;
        }
        #endregion OldWay


        #region NewWayProp
        private string _color;

        public string Color
        {
            get { return _color; }
            set
            { 
                _color = value;
                Console.WriteLine("Color was assigned to " + _color);
            }
        }

        #endregion NewWayProp



        public int NumberOfHorns
        {
            get { return _numberOfHorns; }
            set { _numberOfHorns = value; }
        }


    }
}
