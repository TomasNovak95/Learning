using Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Processor
    {/// <summary>
    /// Tato fukce vytvoří seznam lidí
    /// </summary>
        public void Run()
        {
            Person mirek = new Person();
            mirek.FirstName = "Mirek";
            mirek.LastName = "Vaculka";
            mirek.Age = 30;
            mirek.Height = 180.0;       // pro formát double musí být .0
            Person sabina = new Person();
            sabina.FirstName = "Sabina";
            sabina.LastName = "Kovaříková";
            sabina.Age = 25;
            sabina.Weight = 55m;    // pro formát decimal m
            

            List<Person> people = new List<Person>();
            people.Add(sabina);
            people.Add(mirek);

            Console.WriteLine("Máme tady tyto lidi");
            foreach (Person person in people)       //pro každý person z people, person je instance, která se vytvoří v rámci cyklu foreach
            {
                Console.WriteLine(person.FirstName);
            }
            sabina.Walk();

        }
    }
}
