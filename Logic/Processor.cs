using Logic.Models;
using Logic.Models.Animal;
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
            //PeopleProcess();
            //CarProcess();
            //AnimalProcess();
            Enum.Force force = Enum.Force.Fx;

            switch (force)
            {
                case Enum.Force.Fx:
                    break;
                case Enum.Force.Fy:
                    break;
                case Enum.Force.Fz:
                    break;
                default:
                    break;
            }

        }

        private void AnimalProcess()
        {
            Animal universalAnimal = new Animal(4);      // zde musím zadat počet nohou, protože tam mám Construktor
            Console.WriteLine(universalAnimal.NumberOfLegs);
            Animal papousek = new Animal(2, "Pepa");
            Dog dog = new Dog("Mira", true);
            universalAnimal.MakeNoise();
            dog.MakeNoise();
            dog.TailSwing();

            List<Animal> animals = new List<Animal>
            {
                papousek, dog
            };
            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Animal { animal.Name} sayes:");
                animal.MakeNoise();
                if (animal is Dog)
                {
                    (animal as Dog).TailSwing();    // Casting - vybírá pouze instance typu Dog
                }
            }
        }

        private void CarProcess()
        {
            Car tomasCar = new Car();
            tomasCar.SetMark("Toyota");
            Console.WriteLine("Tomáš has a car with mark: " + tomasCar.GetMark());
            tomasCar.Color = "Silver";
            tomasCar.Horn();
            tomasCar.Horn();
            tomasCar.Horn(5);
            Console.WriteLine("Tomas car horned: " + tomasCar.NumberOfHorns);
        }

        private void PeopleProcess()
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
