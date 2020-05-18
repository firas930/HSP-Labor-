using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, h, fläche, flächeschwerpunkt, Iy, Iz, Ip, Iyz;
           
            Console.WriteLine("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("h: ");
            h = Convert.ToInt32(Console.ReadLine());
            // Fläche 
            fläche = a * b;
            Console.WriteLine("fläche : {0}", fläche);
            Console.ReadKey();
            // Flächeschwerpunkt des Profils 
            flächeschwerpunkt = b / 2;
            Console.WriteLine("flächeschwerpunkt : {0}", flächeschwerpunkt);
            Console.ReadKey();
            //  Flächenträgheitsmomente des Profils

           











        }
    }
}
