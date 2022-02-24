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
    {
        /// <summary>
        /// Vytvoří seznam lidí.
        /// </summary>
        public void Run()
        {
            //PeopleProcess();
            //CarProcess();
            //AnimalProcess();
            Enum.Force force1 = Enum.Force.FY;

            switch (force1)
            {
                case Enum.Force.FX:


                    break;
                case Enum.Force.FY:
                    break;
                case Enum.Force.FZ:
                    break;
                default:
                    break;
            }



        }

        private void AnimalProcess()
        {
            Animal universalAnimal = new Animal(4);
            universalAnimal.MakeNoise();


            Console.WriteLine(universalAnimal.NumberOfLegs);

            Animal papousek = new Animal(2, "Žoli");

            Dog dog = new Dog("Denver", true);
            Console.WriteLine(dog.IsClever);

            dog.MakeNoise();
            dog.TailSwing();

            List<Animal> animals = new List<Animal>
            {
                papousek, dog
            };

            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Animal {animal.Name} sayes:");
                animal.MakeNoise();
                //if (animal.GetType() == typeof(Dog)) // .. dříve
                //{}
                if (animal is Dog)
                {
                    Dog dogFromAnimal = (Dog)animal; // komplikovaný způsob (Dog)Animal .. casting (type casting)
                    dogFromAnimal.TailSwing(); // 


                    (animal as Dog).TailSwing(); // casting
                }
            }
        }

        private void CarProcess()
        {
            Car mireksCar = new Car();
            mireksCar.SetMark("Peugeot");
            Console.WriteLine("Mirek has car with mark: " + mireksCar.GetMark());

            mireksCar.Color = "Yellow";


            mireksCar.Horn();
            mireksCar.Horn();
            mireksCar.Horn(10);
            Console.WriteLine($"Mirek has horned {mireksCar.NumberOfHorns} times.");
        }

        private void PeopleProcess()
        {
            Person mirek = new Person();
            mirek.FirstName = "Miroslav";
            mirek.LastName = "Vaculka";
            mirek.Age = 30;
            mirek.Height = 183.0; // protože double .. double používat v případě vĚdeckých účelů - vyšší přesnost
            mirek.Weight = 78.5m; // protože decimal .. vhodné pro ceny, apod.
            Person sabina = new Person();
            sabina.FirstName = "Sabina";

            List<Person> people = new List<Person>();
            people.Add(mirek);
            people.Add(sabina);

            Console.WriteLine("Máme tu tyto lidi: ");
            foreach (Person person in people) // lze přečíst - "pro každého člověka v seznamu lidí"
            {
                // zde můžeme v tomto bloku složených závorek používat instanci person - nejdříve to bude mirek, potom sabina
                Console.WriteLine(person.FirstName);
            }

            sabina.Walk();
        }
    }
}
