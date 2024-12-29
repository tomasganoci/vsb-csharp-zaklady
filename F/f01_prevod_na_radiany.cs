using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {

    internal class f01_prevod_na_radiany {
        //        public static void Mainx() {
        //            //1) Napište funkci, která převádí stupně a minuty na radiány.
        //            //Proměnné se předávají přes parametry podprogramu, v hlavním programu použijte jiné názvy proměnných než v podprogramu. //
        //            //Návod: řešte trojčlenkou. Plnému kruhu odpovídá 360 stupňů nebo 2 pí radiánů (přibližně 6,28 radiánů).
        //            //Moje poznámky: rovnou jsem použil kombinaci výpočtu minut a radiánu, jinak je to skoro stejné

        //            Function prevodNaRadiany(stupen, minuty float) float
        //                Const pi = 3.14159
        //    prevodNaRadiany = (stupen + (minuty / 60)) * (pi / 180)
        //End Function

        //    zadaneStupne, zadaneMinuty float

        //    zadaneStupne = Console.ReadLine(); Console.WriteLine("Zadejte stupně")
        //    zadaneMinuty = Console.ReadLine(); Console.WriteLine("Zadejte minuty")

        //    Console.WriteLine("Zadané stupně: zadaneStupne)\n
        //            "Zadane minuty: zadaneMinuty)\n
        //            "Počet radiánů: prevodNaRadiany(zadaneStupne, zadaneMinuty)))

        //        }
        public static void Mainx_reseni() {
            //Řešení:
            //Zadejte počet dnů a hodin. Program vypočte,
            //kolik je to hodin (výsledek může být reálné číslo).

            int dny, hodiny;
            Console.WriteLine("zadej pocet dnu:");
            dny = int.Parse(Console.ReadLine());
            Console.WriteLine("zadej pocet hodin:");
            hodiny = int.Parse(Console.ReadLine());
            Console.WriteLine($"celkem to je: {fHodiny(dny, hodiny)}h");

            static int fHodiny(int dd, int hh) {
                return hh + (dd * 24);
            }
        }
    }
}