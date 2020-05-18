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
            
            double Iy, Iz, Iyz, Ip, flächechwerpunkt, b, a, h, fläche;

            Console.WriteLine("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("h: ");
            h = Convert.ToInt32(Console.ReadLine());
            // Fläche 
            fläche = a * b ;
            Console.WriteLine("fläche : {0}", fläche);
            Console.ReadKey();
            // Flächechwerpunkt des Profils 
            flächechwerpunkt = b / 2 ;
            Console.WriteLine("flächechwerpunkt : {0}", flächechwerpunkt);
            Console.ReadKey();
            //  Flächenträgheitsmomente des Profils

            Iy = b * Math.Pow(h, 3) / 12;
            Console.WriteLine("Iy : {0}", Iy);
            Console.ReadLine();


            Iz = h * Math.Pow(b, 3) / 12;
            Console.WriteLine("Iz : {0}", Iz);
            Console.ReadLine();

            Iyz = 0;
            Console.WriteLine("Iyz : {0}", Iyz);
            Console.ReadLine();

            Ip = (h * b * (Math.Pow(h, 2) + Math.Pow(b, 2))) / 12;
            Console.WriteLine("Ip : {0}", Ip);
            Console.ReadLine();




















        }
    }
}
