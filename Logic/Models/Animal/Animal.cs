using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models.Animal
{
    internal /*abstract*/ class Animal   // abstract říká, že nelze dělat instanci třídy Animal
    {
        //      Fields     //

        private int _numberOfLegs;
        private readonly string _name;




        //      Constructors        //
        /// <summary>
        /// "Vytvoří zvíře o daném počtu nohou"
        /// </summary>
        /// <param name="numberOfLegs">Počet nohou</param>
        public Animal(int numberOfLegs) // ctor - zkratka pro tvorbu konstruktoru
        {
            _numberOfLegs = numberOfLegs;
        }
        public Animal(int numberOfLegs, string name)
            :this(numberOfLegs) // volá jiný konstruktor. Který - to pozná podle argumentu. Nejdřív se zavolá konstruktor, pak následuje tento blok:
        {
            _name = name;
        }


        //      Properties          //


        public int NumberOfLegs
        {
            get { return _numberOfLegs; }
        }

        public string Name
        {
            get { return _name; }
        }


        //          Other Methods           //

        public virtual void MakeNoise()
        {
            Console.WriteLine("Making noise..");
        }

    }
}
