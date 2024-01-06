using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_day_c__chalenge.Day6
{
    internal class Point
    {
        private double X;
        private double Y;

        public Point()
        {
            double x; 
            double y;
            Console.WriteLine("Donner l'abscisse:");
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Donner l'ordonne:");
            double.TryParse(Console.ReadLine(), out y);
            X = x;
            Y = y;
        }
        public void Norme()
        {
            double N = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
            Console.WriteLine($"La norme du point ({X},{Y})est : {N}");
        }
    }
}
