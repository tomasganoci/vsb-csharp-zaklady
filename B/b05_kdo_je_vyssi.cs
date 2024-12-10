using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {

    internal class b05_kdo_je_vyssi {

        public static void Mainx() {
            //b5)  Sestavte program, který postupně načte jméno a výšku prvního žáka, a jméno a výšku druhého žáka.
            //Poté zobrazí jméno vyššího z nich.
            //moje poznámka: v deklaraci mám místo "int", "float", zvolil jsem u } else {if a } else { jiný postup

            string jmenoPrvnihoZaka, jmenoDruhehoZaka;
            float vyskaPrvnihoZaka, vyskaDruhehoZaka;

            Console.WriteLine("Sestavte program, který postupně načte jméno a výšku prvního žáka, a jméno a výšku druhého žáka.\r\nPoté zobrazí jméno vyššího z nich.\r");
            Console.WriteLine("Zadejte jméhno prvního žáka a já ti řeknu jestli je vyšší než druhý žák");
            jmenoPrvnihoZaka = Console.ReadLine();
            Console.WriteLine("Zadejte výšku prvního žáka");
            vyskaPrvnihoZaka = float.Parse(Console.ReadLine());

            Console.WriteLine("Zadejte jménno druhého žáka a já ti řeknu, jestli je vyšší než první žák");
            jmenoDruhehoZaka = Console.ReadLine();
            Console.WriteLine("Zadejte výšku druhého žáka");
            vyskaDruhehoZaka = float.Parse(Console.ReadLine());

            if (vyskaPrvnihoZaka > vyskaDruhehoZaka) {
                Console.WriteLine($"Nejvyšší žák je {jmenoPrvnihoZaka}");
            }
            else if (vyskaPrvnihoZaka < vyskaDruhehoZaka) {
                Console.WriteLine($"Nejvyšší žák je {jmenoDruhehoZaka}");
            }
            else {
                Console.WriteLine("Oba žáci jsou stejně vysocí");
            }
        }

        public static void Mainx_reseni() {
            //Řešení:
            //
            //b05: Sestavte program, který postupně načte jméno a výšku prvního žáka, a
            //jméno a výšku druhého žáka.Poté zobrazí jméno vyššího z nich.

            string jm1, jm2;
            int v1, v2;

            Console.WriteLine("Zadej jmeno zaka: ");
            jm1 = Console.ReadLine();
            Console.WriteLine("Zadej vysku zaka[cm]:");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej jmeno zaka: ");
            jm2 = Console.ReadLine();
            Console.WriteLine("Zadej vysku zaka[cm]:");
            v2 = int.Parse(Console.ReadLine());
            if (v1 > v2) {
                Console.WriteLine($"vyšší je {jm1}");
            }
            else if (v1 == v2) {
                Console.WriteLine($"{jm1} a {jm2} maji stejnou vysku");
            }
            else {
                Console.WriteLine($"vyšší je {jm2}");
            }
        }
    }
}