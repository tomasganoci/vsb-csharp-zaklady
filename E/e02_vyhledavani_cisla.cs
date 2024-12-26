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

    internal class e02_vyhledavani_cisla {

        public static void Mainx() {
            //2) Zadejte několik čísel, ukončete nulou. Potom zadáte některé z předtím zadaných čísel. Program vypíše, kolikrát toto číslo předtím padlo.
            //Moje poznámky: zase jsem ještě nepoužil "posledniIndex", použil poprvé vbCrLf, jinak cca stejné

            long[] pole = new long[101];
            long zadaneCislo, vyhledatCislo;
            byte i, zadanychPoli, pocetVyhledanychCisel;
            string zadaneCisla;

            zadaneCisla = "";
            i = 0;
            do {
                Console.WriteLine("Zadejte číslo. Ukončete \"0\"");
                zadaneCislo = long.Parse(Console.ReadLine());
                pole[i] = zadaneCislo;
                zadaneCisla += $"{pole[i]}, ";
                i++;
            } while (zadaneCislo > 0);

            Console.WriteLine($"Jaké číslo mám najít?\nZ těchto čísel:\n{zadaneCisla}");
            vyhledatCislo = long.Parse(Console.ReadLine());

            pocetVyhledanychCisel = 0;
            for (i = 0; i < 100; i++)
                if (pole[i] == vyhledatCislo) {
                    pocetVyhledanychCisel++;
                }

            Console.WriteLine($"Vyhledal jsem číslo {vyhledatCislo} - {pocetVyhledanychCisel}x");
        }

        public static void Mainx_reseni() {
            //Řešení:
            //e2: Zadejte řadu čísel ukončenou nulou. Potom zadáte některé z předtím zadaných čísel.
            //Program vypíše, kolikrát toto číslo předtím padlo.

            int[] cisla = new int[101];
            int i, cislo, hledej, poslIndex;  //poslIndex: index poslední buňky pole s platným číslem
            string s;
            byte poc;

            poc = 0;
            i = 0;
            s = "";
            do {
                Console.WriteLine("zadej cislo (0 konci):", "Pole čísel");
                cislo = int.Parse(Console.ReadLine());
                if (cislo != 0) {
                    cisla[i] = cislo;
                    s += $"{cislo}, ";
                    i++;
                }
            }
            while (cislo != 0);     //nebo Loop while zadaneCislo != 0
            poslIndex = i - 1;  //Tím se kompenzuje i++; za posledním číslerm
            Console.WriteLine("Zadej nějaké předchozí číslo");
            hledej = int.Parse(Console.ReadLine());

            for (i = 0; i < poslIndex; i++)
                if (cisla[i] == hledej) {
                    poc++;
                }

            Console.WriteLine($"{s}\nČíslo {hledej} tam bylo {poc}x");
        }
    }
}