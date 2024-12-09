using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace A {

    internal class a10_radiany_na_stupne {

        public static void Mainx() {
            //a10) Převeďte úhel zadaný v radiánech na stupně.
            //Návod: řešte trojčlenkou. Plnému kruhu odpovídá 360 stupňů nebo 2 pí radiánů (přibližně 6,28 radiánů).
            //Tedy jeden radián je 180/  = 57,296 stupňů.
            //Kdo neví, co jsou radiány, tak tento program nemusí vypracovávat.

            double jedenRadian, radialyNaStupne;

            const double plnyKruh = 360;

            jedenRadian = plnyKruh / (2 * Math.PI);
            Console.WriteLine("Převeďte úhel zadaný v radiánech na stupně.\r\n" +
                              "Návod: řešte trojčlenkou. Plnému kruhu odpovídá 360 stupňů nebo 2 pí radiánů (přibližně 6,28 radiánů).\r\n" +
                              "Tedy jeden radián je 180/  = 57,296 stupňů.\r\n" +
                              "Kdo neví, co jsou radiány, tak tento program nemusí vypracovávat.");
            Console.WriteLine("Zadejte úhel v radiánech a já ti to převedu na stupně");
            radialyNaStupne = double.Parse(Console.ReadLine());

            Console.WriteLine($"Zadaný radialyNaStupne) úhel v radiánech je {radialyNaStupne * jedenRadian:f} stupňů.");
        }

        public static void Mainx_reseni() {
            //Řešení:
            //a10: Převeďte úhel zadaný v radiánech na stupně.
            //
            float rad;

            Console.WriteLine("zadej uhel (rad) ");
            rad = float.Parse(Console.ReadLine());
            Console.WriteLine($"uhel je {rad * 180 / Math.PI:f} °");   //zaokrouhlí na 2 des. místa
        }
    }
}