using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace A {

    internal class a11_prumerna_rychlost {

        public static void Mainx() {
            //a11) Sestavte program, který se zeptá na délku běžecké trati v metrech a poté na čas běžce na této trati ve vteřinách.
            //Poté zobrazí, jakou průměrnou rychlostí v [km/hod] běžec běžel. (program Doc. Homoly)

            float delkaTrati, casNaTrati, prumernaRychlost;

            Console.WriteLine("Sestavte program, který se zeptá na délku běžecké trati v metrech a poté na čas běžce na této trati ve vteřinách.\r\n" +
                              "Poté zobrazí, jakou průměrnou rychlostí v [km/hod] běžec běžel. (program Doc. Homoly)");
            Console.WriteLine("Jakou délku má trať? Zadejte v metrech.");
            delkaTrati = float.Parse(Console.ReadLine());
            Console.WriteLine("Za jak dlouho, běžec doběhl? Zadejte ve vteřinách.");
            casNaTrati = float.Parse(Console.ReadLine());

            prumernaRychlost = delkaTrati / casNaTrati * 60 * 60 / 1000; //slo by to udělat snadněji Str(Round((delka / cas * 3.6), 2)) se zaokrouhlením na 2 desetinná místa

            Console.WriteLine($"Běžec, trať dlouhou {delkaTrati} m, uběhl průměrnou rychlostí {prumernaRychlost:f} km/h");
        }

        public static void Mainx_reseni() {
            //Řešení:
            //a11: Sestavte program, který se zeptá na délku běžecké trati v metrech a
            //poté na čas běžce na této trati ve vteřinách.Poté zobrazí,
            //jakou průměrnou rychlostí v[km / hod] běžec běžel.

            double delka, cas;

            Console.WriteLine("zadej delku trate (m): ");
            delka = float.Parse(Console.ReadLine());
            Console.WriteLine("zadej cas bezce (s): ");
            cas = float.Parse(Console.ReadLine());
            Console.WriteLine($"Prumerna rychlost bezce je {delka / cas * 3.6:f} km/h");
        }
    }
}