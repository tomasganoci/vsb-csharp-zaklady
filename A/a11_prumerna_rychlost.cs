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


    delkaTrati float, casNaTrati float, prumernaRychlost float


    delkaTrati = Console.WriteLine("Jakou délku má trať? Zadejte v metrech.", "Délka tratě")
    casNaTrati = Console.WriteLine("Za jak dlouho, běžec doběhl? Zadejte ve vteřinách.", "Čas běžce na trati")


    prumernaRychlost = (delkaTrati / casNaTrati * 60) * 60 / 1000 //slo by to udělat snadněji Str(Round((delka / cas * 3.6), 2)) se zaokrouhlením na 2 desetinná místa


    MsgBox("Běžec, trať dlouhou {delkaTrati} m, uběhl průměrnou rychlostí {prumernaRychlost} km/h"), , ("Průměrná rychlost běžce na trati")




//Řešení:
//a11: Sestavte program, který se zeptá na délku běžecké trati v metrech a
//poté na čas běžce na této trati ve vteřinách.Poté zobrazí,
//jakou průměrnou rychlostí v[km / hod] běžec běžel.
//
//
//    delka float, cas float
//
//    delka = Console.WriteLine("zadej delku trate (m): ")
//    cas = Console.WriteLine("zadej cas bezce (s): ")
//    Console.WriteLine(("Prumerna rychlost bezce je  {Round((delka / cas * 3.6), 2)} km/h")
//
    
        }
    }
}
