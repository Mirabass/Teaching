using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    internal class Car
    {


        #region OldWay
        // Field:
        private string _mark;

        // Setter (method):
        internal void SetMark(string mark)
        {
            _mark = mark;
        }

        // Getter:
        internal string GetMark()
        {

            return _mark;
        }
        #endregion

        #region NewWayFullProp
        private string _color;

        public string Color // propfull
        {
            get { return _color; }
            set 
            { 
                _color = value;
                Console.WriteLine("Car color was set. Color is: " + _color);
            }
        }
        #endregion

        #region NewWayShortProp 
        public int Doors { get; set; } // prop
        #endregion

        private int _numberOfHorns = 0;

        public int NumberOfHorns
        {
            get { return _numberOfHorns; }
        }



        // Method:
        /// <summary>
        /// Zatroubí jednou.
        /// </summary>
        internal void Horn()
        {
            _numberOfHorns++;
            Console.WriteLine("Car is Horning!!");
        }
        // Overloaded method - jmenuje se stejně, ale má jiné argumenty. Program sám zjistí, kterou metodu voláme podle argumentů.
        /// <summary>
        /// Zatroubí kolikrát chceš.
        /// </summary>
        /// <param name="numberOfHorns">Počet zatroubení.</param>
        internal void Horn(int numberOfHorns)
        {
            _numberOfHorns += numberOfHorns; // to je stejné jako:  _numberOfHorns = _numberOfHorns + numberOfHorns;
            for (int i = 0; i < numberOfHorns; i++)
            {
                Console.WriteLine("Car is Horning!!"); 
            }
        }
    }
}
