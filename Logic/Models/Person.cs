using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    internal class Person
    {
        // Vlasnost - Property:
        public string FirstName { get; set; } // automaticky s otazníkem - je vždy "nullable"
        public string LastName { get; set; }
        // XAML dokumentace - vznikne napsáním tří lomítek /// nad vlastností nebo metodou
        /// <summary>
        /// Věk
        /// </summary>
        public int Age { get; set; }
        public double Height { get; set; }
        public decimal? Weight { get; set; } // ? ... nullable = může být null, není nutné zadat

        // Metoda - Method:
        public void Walk()
        {
            Console.WriteLine(FirstName + " is walking...");
        }

    }
}
