using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace E {

    internal class e04_sportka_bez_duplicit {
        ////4) Upravte program pro Sportku (c3) tak, aby se tažená čísla nemohla opakovat.
        ////Testujte na větším počtu tahů, aby se opakování projevilo.
        ////Ještě lépe se projeví, pokud budete testovat na hodech kostkou (1-6), také nemá padnout stejné číslo dvakrát.
        ////Srovnejte s e2): tam se zjišťuje, kolikrát které číslo padlo.
        ////A nyní se má zajistit, aby vícekrát nepadlo.
        ////Pokud padne, hod se opakuje.
        ////Tento program je dost obtížný.
        ////Pokud zabere neúměrně hodně času, tak jej nechte až na druhou etapu přípravy, tedy po prvním vstupním testu.
        ////Moje poznámky: tenhle příkad je na mě moc těžky..., nechal jsem si ho na konec...,
        ////konečně jsem to vyřešil tím stylem, že to neustále prohledává tažené hodnoty dokud nejsou všechny neduplicitní

        //    Const maxCisel = 49
        //    Const pocetTazenych = 5
        //    cislaSportky[101], tazenaCisla(1 To pocetTazenych) int
        //    i, posledniIndex, d byte //"d" je počítadlo duplicity
        //    soupisTazenych string

        //    for i = i To maxCisel
        //        cislaSportky[i] = i
        //    Next i

        //    Randomize
        ////    i = 1
        //    soupisTazenych = "";
        //    for i = 1 To pocetTazenych
        ////    do {
        //        tazenaCisla[i] = cislaSportky(Int(Rnd()* (maxCisel + 1 - 1) + 1))
        //        for d = 1 To pocetTazenych
        //            if i!= d  && tazenaCisla[i] = tazenaCisla(d) {
        //                tazenaCisla[i] = cislaSportky(Int(Rnd() * (maxCisel + 1 - 1) + 1))
        //                d = 0
        //            }
        //        Next d
        //        soupisTazenych = soupisTazenych + tazenaCisla[i]) + ","
        ////        i++;
        ////    }  while ( i != 50
        //    Next i
        //    Console.WriteLine($"("Tažená čísla: soupisTazenych)

        public static void Mainx() {
            //Řešení:
            //e4: Upravte program pro Sportku (c3) tak, aby se tažená čísla nemohla opakovat.
            //Testujte na větším počtu tahů, aby se opakování projevilo.
            //ještě lépe se projeví, pokud budete testovat na hodech kostkou (1-6), také nemá padnout stejné číslo dvakrát
            const int POCET_TAHU = 6;
            byte[] tahy = new byte[POCET_TAHU];
            byte i, j;
            string s;

            Random rnd = new Random();
            //tahy[0] = Round(Rnd() * 48) + 1        //zdánlivě chodí, ale první a poslední číslo padá je v poloviční četnosti oproti jiným číslům
            tahy[0] = Convert.ToByte(rnd.Next(1, 7));       //všimněte si, že čísla 1 až 49 padají, když se při použití Round násobí *48. Při Int *49
                                                             //testovat na  * 6 místo * 49
            s = $"0 {tahy[0]}";
            i = 0;

            do {
                i++;
                //tahy[i] = Round(Rnd() * 48) + 1        //zdánlivě chodí, ale první a poslední číslo padá je v poloviční četnosti oproti jiným číslům
                tahy[i] = Convert.ToByte(rnd.Next(1, 7));          //všimněte si, že čísla 1 až 49 padají, když se při použití Round násobí *48. Při Int *49
                                                                    //testovat na  * 6 místo * 49
                s += $"\n{i} {tahy[i]}";
                for (j = 0; j < i; j++) {
                    if (tahy[j] == tahy[i]) {
                        s += " sopakovat";
                        i--;
                        break;
                    }
                }
            } while (i < POCET_TAHU - 1);

            Console.WriteLine($"{s}");
        }
}
}