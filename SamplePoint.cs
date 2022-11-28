using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyModifierPOC
{
    public class SamplePoint
    {
        public int x;
        // Initializing a readonly field
        public readonly int y = 25;
        public readonly int z;

        public SamplePoint()
        {
            // Initializing a readonly instance field
            z = 24;
        }

        public SamplePoint(int p1, int p2, int p3)
        {
            x = p1;
            y = p2;
            z = p3;
        }

        public static void Main()
        {
            SamplePoint p1 = new SamplePoint(11, 21, 32);   
            Console.WriteLine($"p1: x={p1.x}, y={p1.y}, z={p1.z}");

            SamplePoint p2 = new SamplePoint();
            p2.x = 55;   
            Console.WriteLine($"p2: x={p2.x}, y={p2.y}, z={p2.z}");
           
           //p2.y = 66;  // A readonly field cannot be assigned to(except in a constructor or a variable initializer)
        }
    }
}