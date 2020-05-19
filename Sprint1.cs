using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Iy, Iz, Iyz, Ip, flaechechwerpunkt, b, a, h, flaeche, Volume, Masse, Dichte  ;

            Console.WriteLine("a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("h: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dichte: ");
            Dichte = Convert.ToDouble(Console.ReadLine());

            if ((b > 0) && (a > 0) && (h > 0) && (Dichte > 0))
            {
                // Flaeche 
                fläche = 2 * a * 2 * b * 2 * h;
                Console.WriteLine("flaeche : {0}", flaeche);
                Console.ReadKey();

                // Volume
                Volume = a * b * h;
                Console.WriteLine("Volume : {0}", Volume);
                Console.ReadKey();

                // Masse 
                Masse = Dichte * Volume;
                Console.WriteLine("Masse : {0}", Masse);
                Console.ReadKey();

                // Flaechechwerpunkt des Profils 
                flaechechwerpunkt = b / 2;
                Console.WriteLine("flaechechwerpunkt : {0}", flächechwerpunkt);
                Console.ReadKey();
                //  Flaechenträgheitsmomente des Profils

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
            else
            {
                Console.WriteLine("Bitte geben eine gültige nummer ein");
                Console.ReadLine();
            }
        } 
    }
}
