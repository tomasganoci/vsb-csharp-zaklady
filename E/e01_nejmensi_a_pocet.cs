using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace E {

    internal class e01_nejmensi_a_pocet {

        public static void Mainx() {
            //1) Zadejte řadu čísel ukončenou nulou. Zjistěte nejmenší a vypište, kolikrát se v řadě opakuje.
            //(návod: v druhé smyčce se najde minimum. A tentokrát bude i smyčka třetí, ve které se zjistí, kolikrát se v poli toto minimum vyskytuje).
            //Pozn.: lze řešit i dvěma smyčkami, první a druhá se spojí do jedné.
            //Tedy čísla se zadávají a hned se zjišťuje, zdali není menší, než dosavadní minimum.
            //Pozn.: šlo by to i jednou smyčkou, ale to už je náročnější. A nebylo by v tom případě nutné pole.
            //Moje poznámky: jako první příklad jsem neměl podchycený "posledniIndex", jinak je to víceméně stejné,

            int[] pole = new int[101];
            int zadaneCislo, min;
            byte i, pocetZadanychCisel, pocetMin;
            string vypisCisel;
            pocetMin = 1;

            i = 0;
            vypisCisel = "";
            do {
                Console.WriteLine("Zadávejte čísla postupně. Vypíšu ti nejmenší číslo a kolikrát se objevuje. Ukončíte \"0\"");
                zadaneCislo = int.Parse(Console.ReadLine());
                pole[i] = zadaneCislo;
                vypisCisel += $"{pole[i]}, ";
                i++;
            } while (zadaneCislo > 0);
            i--;

            pocetZadanychCisel = Convert.ToByte(i - 1);
            min = pole[0];
            for (i = 0; i < pocetZadanychCisel; i++)
                if (min > pole[i]) {
                    min = pole[i];
                }
            for (i = 0; i < pocetZadanychCisel; i++)
                if (min == pole[i]) {
                    pocetMin += 1;
                }

            Console.WriteLine($"Výpis čísel: {vypisCisel}\n" +
                    $"Minimální číslo: {min}\n" +
                    $"Počet výskytu minimálního čísla: {pocetMin}");
        }

        public static void Main_reseni() {
            //Řešení:
            //e1:Zadejte čísla ukončená nulou.
            //Zjistěte nejmenší a vypište, kolikrát je obsaženo.

            int[] cisla = new int[101];
            int zadaneCislo, i, min, pocetMin, poslIndex;  //poslIndex: index poslední buňky pole s platným číslem
            string s;
            pocetMin = 0;
            i = 0;
            s = "";

            do {
                Console.WriteLine("Zadej cisla, nula = konec");
                zadaneCislo = int.Parse(Console.ReadLine());
                if (zadaneCislo != 0) {
                    cisla[i] = zadaneCislo;
                    s += $"{zadaneCislo}, ";
                    i++;
                }
            }
            while (zadaneCislo != 0);
            poslIndex = i - 1;  //Tím se kompenzuje i++; za posledním číslem

            min = cisla[0];
            for (i = 1; i < poslIndex; i++)
                if (cisla[i] < min) {
                    min = cisla[i];
                }
            for (i = 0; i < poslIndex; i++)
                if (min == cisla[i]) {
                    pocetMin++;
                }
            Console.WriteLine($"{s}\nNejmenší číslo v řadě je {min} a vyskytuje se tam {pocetMin}krát.");
        }

        public static void Main_reseni2() {
            //ukázka, že to jde zvládnout i jednou smyčkou. Tím pádem je ale pole zbytečné.
            byte cislo;
            byte min, pocetMin, i;

            i = 0;    
            pocetMin = 0;
            min = 0;
            do {
                Console.WriteLine("Zadej cislo:");
                cislo = byte.Parse(Console.ReadLine());
                if (i == 0) {
                    min = cislo;
                    pocetMin = 1;
            }
                else {
                    if (cislo == min) {
                        pocetMin++;
                        }
                    if (cislo < min && cislo != 0) {
                        min = cislo;
                        pocetMin = 1;  //toto přidáno
                }
                }
                i++;
            } while (cislo != 0);

            Console.WriteLine($"Minimum je {min} a vyskytlo se {pocetMin} krat.");
            }
    }
}
 