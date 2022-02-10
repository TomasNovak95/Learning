using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FileProcessor        //internal možnost přístupnosti, private (pouze v rámci třídy), public (všude), internal (v rámci projektu)
    {                   //pravý alt + b = složené závorky
        public string Path  { get; set; }     //vlastnost

        public void LoadFile()          //void = nevrací nic
        {
           Console.WriteLine($"načítám soubor z cesty:\n {Path}"); // pravý alt + Q = zpětné lomítko
        }
    }
}
