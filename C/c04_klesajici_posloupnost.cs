using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {

    internal class c04_klesajici_posloupnost {

        public static void Mainx() {
            //4)  Vypište klesající posloupnost čísel od 8 do -8.  Varianta: vypište stejnou posloupnost, ale pouze každé druhé (sudé) číslo. (Nepoužívejte if.)

            //Moje poznámky: jen jsem doplnil nadpis okna,

            int min = -8;
            int max = 8;
            int i = 0;

            string klesajiciCislo = "";
            for (i = max; i >= min; i--) {
                klesajiciCislo += $"{i}, ";
            }

            string klesajiciSudeCislo = "";
            for (i = max; i >= min; i -= 2) {
                klesajiciSudeCislo += $"{i}, ";
            }
            Console.WriteLine($"Vzorec: for i = 8 To -8 Step -1 \n" +
                              $"{klesajiciCislo}\n" +
                              $"\n" +
                              $"Vzorec: for i = 8 To -8 Step -2\n" +
                              $"{klesajiciSudeCislo}");

            ////Řešení:

            ////c04: Vypište klesající posloupnost čísel od 8 do -8.

            //private Sub main_reseni()
            //  i int

            //  s string

            //  s = "";
            //  for i = 8 To -8 Step -1
            //    s = s + \n + i)
            //  Next
            //  Console.WriteLine($"s, , ("posloupnost 8 az -8")

            ////Varianta: vypište stejnou posloupnost, ale pouze každé druhé (sudé) číslo. (Nepoužívejte if.)
            //Sub main_reseni2()
            //  i int
            //  s string

            //    s = "";
            //    for i = 8 To -8 Step -2
            //        s = s + \n + i)
            //    Next
            //    Console.WriteLine(s)
            //    }
            //}
        }
    }
}