using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {

    internal class d04_nejvyssi_zak {

        public static void Mainx_reseni_do_while() {
            //Řešení:

            //d04: Varianta na B5: Program postupně čte nejprve jméno a pak výšku žáka.
            //Prázdné jméno načítání ukončuje. Poté zobrazí jméno a výšku nejvyššího žáka.
            //------ když nejvyšší jsou 2 a více, tak stačí, když napíše jen jednoho -------

            string jmeno, jmenoMax;
            byte vyska, vyskaMax;
            bool zadanAsponJedenZak;

            vyskaMax = 0;
            bool prvniPruchod = true;
            jmenoMax = "";
            vyska = 0;
            do {
                Console.WriteLine("Zadej jméno žáka:");
                jmeno = Console.ReadLine();
                if (jmeno == "") {
                    zadanAsponJedenZak = false;
                }
                else {
                    zadanAsponJedenZak = true;
                }
                if (jmeno != "") {
                    Console.WriteLine("Zadej výšku žáka [cm]:");
                    vyska = byte.Parse(Console.ReadLine());

                    if (prvniPruchod == true) {
                        jmenoMax = jmeno;
                        vyskaMax = vyska;
                        prvniPruchod = false;
                    }
                    if (vyska > vyskaMax) {
                        vyskaMax = vyska;
                        jmenoMax = jmeno;
                    }
                }
            }
            while (jmeno != "");

            if (zadanAsponJedenZak == true) {
                Console.WriteLine($"Nejvyšší je {jmenoMax} s výškou {vyskaMax} cm");
            }
            else {
                Console.WriteLine("Nebyl zadán žádný žák");
            }
        }

        public static void Mainx() {
            //4) Varianta na b5): Program postupně čte nejprve jméno a pak výšku žáka. Prázdné jméno načítání ukončuje.
            //Poté zobrazí jméno a výšku nejvyššího žáka. Když jsou nejvyšší dva a více stejně vysocí, napíše jen jednoho.
            //Bude zdokonaleno později v sekci e) v BasicCv_těžší
            //Moje poznámky: neočetřil jsem situaci, kdy při prvním zadáni se nezadá jméno žáka a tím se program ukončí bez výsledku,
            //                vstupy v řešení se udělali na začátku,

            string jmeno, zaci, nejvyssiZak;
            float vyska, nejvyssi;
            nejvyssiZak = "";
            zaci = "";
            vyska = 0;
            nejvyssi = 0;
            do {
                Console.WriteLine("Zadejte jméno žáka. Prazné pole program ukončuje.");
                jmeno = Console.ReadLine();
                if (jmeno != "") {
                    Console.WriteLine("Zadejte výšku v cm a já ti řeknu, kdo je nejvyšší");
                    vyska = float.Parse(Console.ReadLine());
                    zaci += $"Jméno žáka: {jmeno}, Výška: {vyska} cm\n";
                    if (vyska > nejvyssi) {
                        nejvyssi = vyska;
                        nejvyssiZak = $"Nejvyšším žákem je {jmeno} s výškou {nejvyssi} cm";
                    }
                }
            } while (jmeno != "");

            Console.WriteLine($"{zaci}\n{nejvyssiZak}");
        }

        public static void Mainx_reseni() {
            //Řešení:

            //d04: Varianta na B5: Program postupně čte nejprve jméno a pak výšku žáka.
            //Prázdné jméno načítání ukončuje. Poté zobrazí jméno a výšku nejvyššího žáka.
            //------ když nejvyšší jsou 2 a více, tak stačí, když napíše jen jednoho -------

            string jmeno, jmenoMax;
            byte vyska, vyskaMax;
            bool zadanAsponJedenZak;

            Console.WriteLine("Zadej jméno žáka:");
            jmeno = Console.ReadLine();
            Console.WriteLine("Zadej výšku žáka [cm]:");
            vyska = byte.Parse(Console.ReadLine());
            jmenoMax = jmeno;
            vyskaMax = vyska;
            if (jmeno == "") {
                zadanAsponJedenZak = false;
            }
            else {
                zadanAsponJedenZak = true;
            }

            while (jmeno != "") {   //Ukázka případu, kdy je vhodné dát podmínku na začátek cyklu
                Console.WriteLine("Zadej jmeno zaka:");
                jmeno = Console.ReadLine();
                if (jmeno != "") {
                    Console.WriteLine("Zadej vysku zaka [cm]:");
                    vyska = byte.Parse(Console.ReadLine());
                    if (vyska > vyskaMax) {
                        vyskaMax = vyska;
                        jmenoMax = jmeno;
                    }
                }
            }

            if (zadanAsponJedenZak = true) {
                Console.WriteLine($"Nejvyšší je {jmenoMax} s výškou {vyskaMax} cm");
            }
            else {
                Console.WriteLine("Nebyl zadán žádný žák");
            }
        }
    }
}