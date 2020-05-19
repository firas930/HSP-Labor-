using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace Sprint2
{
    class Program
    {
        static void Main(string[] args)


        {
            // Kreis

            double radius,  durchmesser;

            Console.WriteLine("Gib den Radius ein!");
            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gib den durchmesser ein!");
            durchmesser = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iy = Iz beträgt " + (Math.PI * Math.Pow(durchmesser, 4)) / 64);

            Console.WriteLine("Wz = Wy beträgt " + (Math.PI * Math.Pow(durchmesser, 3)) / 32);

            Console.ReadLine();

            // Rechteck

            double  Breite, Höhe;

            Console.WriteLine("Gib die Breite ein: ");
            Breite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib die Höhe ein: ");
            Höhe= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iy = Iz " + (Breite * Math.Pow(Höhe, 3) / 12));
            Console.WriteLine("Wy = Wz " + (Breite * Math.Pow(Höhe, 2) / 6));
            Console.ReadLine();

            // Vor letzte

            double B, b, H, h;

            Console.WriteLine("Gib B ein");
            B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib b ein");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib H ein");
            H = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib h ein");
            h = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iy= " + (B * Math.Pow(H, 3) - b * Math.Pow(h, 3)) / 12);
            Console.WriteLine("Wy= " + (B * Math.Pow(H, 3) - b * Math.Pow(h, 3)) / 6 * H);
            Console.ReadLine();

            // Oval

            double a, c;

            Console.WriteLine("Gib c ein");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib a ein");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib h ein");

            Console.WriteLine("Iy= " + (Math.PI * Math.Pow(a, 3) * c) / 4);
            Console.WriteLine("Iz= " + (Math.PI * Math.Pow(c, 3) * a) / 4);
            Console.WriteLine("Wy= " + (Math.PI * Math.Pow(a, 2) * c) / 4);
            Console.WriteLine("Wz= " + (Math.PI * Math.Pow(c, 2) * a) / 4);
            Console.ReadLine();

            // dreieck

            double breite, höhe;

            Console.WriteLine("Gib die breite ein: ");
            breite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Gib die höhe ein: ");
            höhe = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iy= " + (breite * Math.Pow(höhe, 3)) / 36);
            Console.WriteLine("Iz= " + (höhe * Math.Pow(breite, 3)) / 48);
            Console.WriteLine("Wy= " + (breite * Math.Pow(höhe, 2)) / 24);
            Console.WriteLine("Wz= " + (höhe * Math.Pow(breite, 2)) / 24);
            Console.WriteLine("e= " + (2 / 3) * höhe);
            Console.ReadLine();

















        }



    }
}
