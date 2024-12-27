using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace E {

    internal class e06_generator_pismen {
        ////6) Zadejte postupně několik písmen.
        ////Program potom náhodně vygeneruje slovo (shluk písmen), které se bude skládat z těchto písmen (např. vždy 5 znaků).
        ////Písmena se mohou opakovat a nemusí být použita všechna.
        ////Pozn. zadávání můžete ukončit třeba číslem 0 nebo třeba stiskem klávesy enter.
        ////(Varianta: vygenerujte třeba 10 slov.)
        ////Varianta: Místo zadání z klávesnice vygeneruje prvotních několik písmen počítač.
        ////Moje poznámky: celkově jsem to jinak navrhnul, nevím jestli dobře nebo špatně, ppužil jsem 5x náhodné písmeno a 5x zadané.

        //    Const pole = 9

        //    polePismen(pole), nahodnePismeno, zadanePismeno, slovo, poleSlov(9), vypisSlov string
        //    i, nahodneCislo, pocetSlov byte

        //    Randomize
        //    for i = 0 To 4
        //        nahodnePismeno = Chr(Int(Rnd()* (90 - 65 + 1) + 65))
        //        polePismen[i] = nahodnePismeno
        //    Next

        //    do {
        //        zadanePismeno = Console.ReadLine();Console.WriteLine("Zadejte velké písmeno a já ti napíšu náhodné slovo. 5x.")
        //        polePismen[i] = zadanePismeno
        //        i++;
        //    }  while ( i< 10

        //    slovo = "";
        //    vypisSlov = "";
        //    for pocetSlov = 0 To 9
        //        slovo = "";
        //        for i = 0 To 4
        //            nahodneCislo = Int(Rnd()* (pole - 0 + 1))
        //            do { While polePismen(nahodneCislo) = "";
        //                nahodneCislo = Int(Rnd()* (pole - 0 + 1))
        //            Loop
        //            slovo = slovo + polePismen(nahodneCislo)
        //        Next
        //    poleSlov(pocetSlov) = slovo
        //    vypisSlov = vypisSlov + slovo\n
        //    Next
        //    Console.WriteLine("Vygenerované slova:"\nvypisSlov)

        public static void Mainx() {
            //Řešení:
            //e6: Zadejte postupně několik písmen. Program potom náhodně vygeneruje slovo (shluk písmen), které se bude skládat z těchto písmen (např. vždy 5 znaků).
            //Písmena se mohou opakovat a nemusí být použita všechna. Pozn. zadávání můžete ukončit třeba číslem 0 nebo třeba stiskem klávesy enter.
            //Varianta pro pokročilé: vygenerujte těch slov třeba 10)
            //Varianta: Místo zadání z klávesnice vygeneruje prvotních několik písmen počítač.
            char[] znaky = new char[10];
            string s1, s2, znakString;
            char znak;
            int i, nah, j, delkaSlova, pocetZnaku;
            i = 0;
            s1 = "";
            s2 = "";              //proměnná j se zde neinicializuje. Ta se inicializuje ve smyčce for.

            //pocetZnaku = 5                      //varianta pro generování místo zadání z klávesnice
            //for i = 0 To pocetZnaku - 1
            //    znaky[i] = Chr(Int(Rnd() * 26) + 97)
            //    s1 = s1 znaky[i]
            //Next
            Random rnd = new Random();
            do {
                Console.WriteLine("Zadej malé písmeno, zadávání ukončíš prázdným ENTERem");
                znakString = Console.ReadLine(); 
                if (znakString != "") {
                    znak = char.Parse(znakString);
                    if (znak >= 'a' && znak <= 'z') {  //ověřte si, že ostatní znaky (např. číslice) ignoruje
                        s1 += $"{znak}";
                        znaky[i] = znak;
                        i++;
                    }
                }
            }
            while (znakString != "");                  //nebo }  while ( znak != \"
            pocetZnaku = i;
            delkaSlova = 5;

            for (j = 1; j < 10; j++) {                    //tento řádek navíc pro variantu
                for (i = 0; i < delkaSlova - 1; i++) {
                    //nah = Rnd() * (pocetZnaku - 1)  chyba: nelze využívat toho, že VB je ochoten double uložit o int

                    nah = rnd.Next(pocetZnaku);

                    s2 += $"{znaky[nah]}";
                }

                s2 = $"{s2}\n";            //tento řádek navíc pro variantu
            }                            //tento řádek navíc pro variantu

            Console.WriteLine($"Zadane znaky: {s1}\nVygenerovane shluky: \n{s2}");
        }
    }
}