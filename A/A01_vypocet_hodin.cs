using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace A {
    internal class A01_vypocet_hodin {
        public static void Mainx() {

            //a1) Zadejte počet dnů a hodin. Program vypočte, kolik je to hodin (výsledek může být reálné číslo)   
            float zadaneHodiny, zadaneDny, prevodDnuNaHodiny;

            Console.WriteLine("Zadejte počet dní");
            zadaneDny = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte počet hodin");
            zadaneHodiny = float.Parse(Console.ReadLine());


            prevodDnuNaHodiny = zadaneDny * 24;


            Console.WriteLine($"Z toho, co jsi zadal jsem vypočítal, že je to {prevodDnuNaHodiny+zadaneHodiny} hodin");
        }
        public static void Mainx_reseni() {
            //Řešení:
            //a01: Zadejte počet dnů a hodin.Program vypočte,
            //kolik je to hodin(výsledek může být reálné číslo).
            //

            float dny, hodiny; //Single proto, že v zadání je, že výsledek může být číslo s desetinnou částí. Jinak by stačil Integer

            Console.WriteLine("zadej pocet dnu:");
            dny = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej pocet hodin:");
            hodiny = float.Parse(Console.ReadLine());
            Console.WriteLine(($"celkem to je: {hodiny + dny * 24} h")); 
        }
    }
}
