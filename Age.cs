using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyModifierPOC
{
    class Age
    {
        private readonly int _year;
        Age(int year)
        {
            _year = year;
        }
        void ChangeYear()
        {
           // _year = 1967; // Compile error if uncommented.

        }
        public static void Main()
        {
           // Console.WriteLine("Value of _year is " + _year);
        }
    }
}
