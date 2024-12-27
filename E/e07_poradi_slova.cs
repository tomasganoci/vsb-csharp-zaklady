using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace E {

    internal class e07_poradi_slova {
        ////7) Zadejte postupně do pole několik různých slov.
        ////Každé slovo přitom budete zadávat zvlášť.
        ////Poté znovu zadejte jedno z těchto slov.
        ////Program vypíše číslo pořadí, v jakém bylo toto slovo zadáno (na jaké pozici se vyskytuje v poli).
        ////Moje poznámky: posledniIndex dát za smyčku, dal do smyčky podmínku s prázným polem... je to takto lepší?,

        //    slovaPole(1 To 100), zadaneSlovo, vysledneSlovo string
        //    i, pocetSlov, posledniIndex byte

        //    i = 1
        //    do {
        //        zadaneSlovo = Console.ReadLine();Console.WriteLine("Zadejte slovo. Ukončíte tlačítkem \"cancel\"")
        //        slovaPole[i] = zadaneSlovo
        //        posledniIndex = i - 1
        //        i++;
        //        pocetSlov = pocetSlov + 1
        //    }  while ( zadaneSlovo!= \"

        //    vysledneSlovo = Console.ReadLine();Console.WriteLine("Zadejte slovo, které mám vyhledat")

        //    for i = 1 To pocetSlov
        //        if slovaPole[i] = vysledneSlovo {
        //            Console.WriteLine("Slovo:  slovaPole[i]\n
        //                    "Pořadí:  i)\n)
        //        }
        //    Next
        public static void Mainx() {
            //Řešení:
            //e7: Zadejte postupně do pole několik slov. Každé slovo přitom budete zadávat zvlášť. Poté znovu zadejte jedno z těchto slov.
            //Program vypíše číslo pořadí, v jakém bylo toto slovo zadáno (na jaké pozici se vyskytuje v poli).
            string[] poleSlov = new string[101];
            string zadaneSlovo, s, znovu;
            int i, poradi, poslIndex; //poslIndex: index poslední buňky pole s platným číslem
            i = 0;
            s = "";
            poradi = 0;

            do {
                Console.WriteLine("Zadej slovo, zadavani ukoncis prázdným ENTERem");
                zadaneSlovo = Console.ReadLine();
                if (zadaneSlovo != "") {
                    s += $"\n{zadaneSlovo}";
                    poleSlov[i] = zadaneSlovo;
                    i++;
                }
            }
            while (zadaneSlovo != "");
            poslIndex = i;   //Tím se kompenzuje i++; za posledním číslerm

            Console.WriteLine("Zadej znovu jedno ze zadanych slov");
            znovu = Console.ReadLine();
            for (i = 0; i < poslIndex; i++) {
                if (znovu == poleSlov[i]) {
                    poradi = i + 1;
                }
            }

            if (poradi == 0) {
                Console.WriteLine("zadané slovo v sadě není");
            }
            else {
                Console.WriteLine($"Zadana slova:\n{s}\nSlovo {znovu} bylo zadano jako {poradi} v poradi");
            }
        }
    }
}