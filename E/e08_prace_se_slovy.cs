using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace E {

    internal class e08_prace_se_slovy {
        ////8) Řadu slov z předchozího příkladu vypište v obráceném pořadí, a pak vypíše pouze sudá a pak pouze lichá slova.
        ////A předělejte příklady c) a d) na pole. Tedy nezpracovávejte je v první smyčce, ale až v druhé.
        ////Moje poznámky: zase jiný posledníIndex, jinak řešeno počítadlo, dává podmínku do "do {", což jsem si myslel, že je lepší, čím méně podmínek tím lépe, když to není třeba.

        //    slovaPole(1 To 100), zadaneSlovo, vypisSlov, vypisSude, vypisLiche string
        //    i int
        //    posledniIndex byte

        //    i = 1
        //    do {
        //    zadaneSlovo = Console.ReadLine();Console.WriteLine("Zadejte slovo. Ukončíte tlačítkem \"Cancel\"")
        //    slovaPole[i] = zadaneSlovo
        //    posledniIndex = i - 1
        //    i++;
        //    }  while ( zadaneSlovo!= \"

        //    vypisSlov = "Pořadí obráceně      Slovo"\n
        //    vypisSude = "Pořadí sudé      Slovo"\n
        //    vypisLiche = "Pořadí liché      Slovo"\n

        //    for i = posledniIndex To 1 Step -1
        //        vypisSlov = vypisSlov + i)                        slovaPole[i]\n
        //        if i % 2 = 0 {
        //            vypisSude = vypisSude + i)                        slovaPole[i]\n
        //        } else {
        //            vypisLiche = vypisLiche + i)                        slovaPole[i]\n
        //        }
        //    Next

        //    Console.WriteLine("vypisSlov\nvypisSude\nvypisLiche)

        //Řešení:
        //e8: Řadu slov z předchozího příkladu vypište v obráceném pořadí,
        //a pak vypíše pouze sudá a pak pouze lichá slova.
        public static void Mainx() {
            string[] poleSlov = new string[101];
            string vstup, s, sZpet, sLicha, sSuda;
            int i, j, poslIndex;   //poslIndex: index poslední buňky pole s platným číslem
            i = 0;
            s = "";
            sZpet = "";
            sLicha = "";
            sSuda = "";

            do {
                Console.WriteLine("Zadej slovo, zadávání ukončíš prázdným ENTERem");  //nebo ENTERem
                vstup = Console.ReadLine();
                if (vstup != "") {
                    s += $"\n{vstup}";    //místo vbCrLf lze i Chr(10)
                    poleSlov[i] = vstup;
                    i++;
                }
            }
            while (vstup != "");
            poslIndex = i -1;   //Tím se kompenzuje i++; za posledním číslerm

            for (i = poslIndex; i > -1; i--) {
                sZpet += $"\n{poleSlov[i]}";
            }

            for (j = 0; j < poslIndex + 1; j++) {
                if ((j+1) % 2 == 0) {
                    sSuda += $"\n{poleSlov[j]}";
                }
                else {
                    sLicha += $"\n{poleSlov[j]}";
                }
            }

            Console.WriteLine($"Zadana slova: {s}\nObraceny vypis: {sZpet}\nLicha: {sLicha}\nSuda: {sSuda}");
        }
    }
}