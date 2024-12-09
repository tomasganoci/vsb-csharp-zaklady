using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace A {

    internal class a06_obvod_a_plocha {

        public static void Mainx() {
            //a6) Zadejte poloměr kruhu. Vypočítejte obvod (o=2*pi*r) a plochu (P=pi*r^2).

            double polomerKruhu;

            Console.WriteLine("Zadejte poloměr kruhu. Vypočítejte obvod (o=2*pi*r) a plochu (P=pi*r^2).");
            Console.WriteLine("Zadejte poloměr kruhu, abych ti mohl vypočítat obvod a plochu");
            polomerKruhu = double.Parse(Console.ReadLine());

            Console.WriteLine($"Výpočitaný obvod je {2 * Math.PI * polomerKruhu:f} a plocha {Math.PI * Math.Pow(polomerKruhu, 2.0):f}");
        }

        public static void Mainx_reseni() {
            //Řešení:
            //a06: Zadejte poloměr kruhu.Vypočítejte obvod(o= 2 * pi * r) a plochu(P= pi * r ^ 2).
            //

            float r;
            string vypis;
            Console.WriteLine("zadej polomer kruhu ");
            r = float.Parse(Console.ReadLine());
            vypis = $"obvod kruhu je:  {2 * Math.PI * r:f} cm \n" +
                    $"plocha kruhu je: {Math.PI * r * r:f} cm^2";
            Console.WriteLine(vypis);
        }
    }
}