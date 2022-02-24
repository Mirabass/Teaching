using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models.Animal
{
    internal sealed class Dog : Animal // sealed .. nelze dále dědit z třídy dog
    {
        private bool _isClever;

        public bool IsClever
        {
            get { return _isClever; }
        }

        public Dog(string name, bool isClever)
            :base(4, name) // Calling constructor of base class
        {
            _isClever = isClever;
            // base.MakeNoise(); .. lze zavolat virtual metodu v base class
        }

        public override void MakeNoise()
        {
            
            Console.WriteLine("Woof");
        }

        public void TailSwing()
        {
            Console.WriteLine(base.Name + " is swinging with its tail."); // .. base je zde zbytečné
        }

    }
}
