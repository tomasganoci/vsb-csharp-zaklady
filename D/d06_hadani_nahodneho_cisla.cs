using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {

    internal class d06_hadani_nahodneho_cisla {

        public static void Mainx() {
            //6) Upraveno podle Doc. Homoly: Sestavte program, který si myslí (náhodně vygeneruje) celé číslo z intervalu <1,10>.
            //Pak ho vy hádáte (zadáváte z klávesnice), dokud se nestrefíte.
            //Počítač vypíše, na který pokus se to podařilo.
            //Moje poznámka: dodělal jsem i podmínku, kdyý se něco zadá mimo rozsah, jiný postup řešení s méně detaily,

            double nahodneCislo;
            int zadaneCislo, min, max;
            byte pokus;
            string zadaneCisla;

            pokus = 0;
            min = 1;
            max = 10;
            Random random = new Random();
            nahodneCislo = Math.Round(random.NextDouble() * (max - min + 1) + min,0);
            zadaneCislo = 0;
            zadaneCisla = "";
            do {
                Console.WriteLine("Hádej číslo od 1 do 10, které si myslím. Pokračejeme dokud neuhádneš.", "Hádání čísel");
                zadaneCislo = int.Parse(Console.ReadLine());
                if (zadaneCislo >= min && zadaneCislo <= max && zadaneCislo != nahodneCislo) {
                    Console.WriteLine("To není správně. Zkus to znovu!");
                    zadaneCisla += $"{zadaneCislo}, ";
                    pokus++;
                }
                else {
                    if (zadaneCislo != nahodneCislo) {
                        Console.WriteLine($"Zadal jsi číslo mimo rozsah!");
                    }
                }
            } while (zadaneCislo != nahodneCislo);
            Console.WriteLine($"Uhádl jsi to!!! Je to číslo {nahodneCislo}. Na {pokus + 1} pokus\n" +
                    $"Použitá čísla: {zadaneCisla + zadaneCislo}");
        }

        public static void Mainx_reseni() {
            //Řešení:

            //d06: Program Doc. Homoly: Sestavte program, který si myslí (náhodně vygeneruje) celé číslo z intervalu <1,10>.
            //Pak ho vy hádáte (zadáváte z klávesnice), dokud se nestrefíte. Počítač vypíše, na který pokus se to podařilo.

            byte nah, hadam, i;
            hadam = 0;

            i = 0;
            Random random = new Random();
            nah = Convert.ToByte(random.NextDouble() * 10 + 1);
            while (nah != hadam) {
                Console.WriteLine("Hádej číslo [1-10]");
                hadam = byte.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"číslo {nah} bylo uhádnuto na {i}.pokus");
        }
    }
}