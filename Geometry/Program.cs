using System;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du kan vælge at regne arealet af en Firkant, Ret vinklet trekant eller en cirkel ud");
            Console.WriteLine("Firkant: F");
            Console.WriteLine("Retvinklet trekant: R");
            Console.WriteLine("Cirkel: C");

            string valg = Console.ReadLine();

            switch (valg.ToLower())
            {
                case "c":
                    Console.WriteLine("Angiv radiussen for din cirkel");
                    double radius = Convert.ToDouble(Console.ReadLine());

                    // Beregning

                    double areal = Math.PI * radius * radius;

                    Console.WriteLine("Arealet af din cirkel er {0}.", areal);

                    break;

            }

        }
    }
}
