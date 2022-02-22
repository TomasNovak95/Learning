using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    internal class Car
    {
        //Methods
        internal void Horn()                            // třída má metody
        {
            Console.WriteLine("Car is horning!");
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
        public string color { get; set; }
        #endregion NewWayProp


    }
}
