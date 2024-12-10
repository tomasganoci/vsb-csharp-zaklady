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
        

//7) Zadejte postupně do pole několik různých slov.
//Každé slovo přitom budete zadávat zvlášť.
//Poté znovu zadejte jedno z těchto slov.
//Program vypíše číslo pořadí, v jakém bylo toto slovo zadáno (na jaké pozici se vyskytuje v poli).
//Moje poznámky: posledniIndex dát za smyčku, dal do smyčky podmínku s prázným polem... je to takto lepší?,


    slovaPole(1 To 100) string, zadaneSlovo string, vysledneSlovo string
    i byte, pocetSlov byte, posledniIndex byte

    i = 1
    Do
        zadaneSlovo = Console.WriteLine(Zadejte slovo. Ukončíte tlačítkem \"cancel\"")
        slovaPole(i) = zadaneSlovo
        posledniIndex = i - 1
        i = i + 1
        pocetSlov = pocetSlov + 1
    Loop While zadaneSlovo<> \"
    
    vysledneSlovo = Console.WriteLine(Zadejte slovo, které mám vyhledat")


    For i = 1 To pocetSlov
        if slovaPole(i) = vysledneSlovo {
            Console.WriteLine("Slovo: " + slovaPole(i) + Chr(10) + 
                    "Pořadí: " + i) + Chr(10))
        }
    Next


//Řešení:
//e7: Zadejte postupně do pole několik slov. Každé slovo přitom budete zadávat zvlášť. Poté znovu zadejte jedno z těchto slov.
//Program vypíše číslo pořadí, v jakém bylo toto slovo zadáno (na jaké pozici se vyskytuje v poli).
Sub main_reseni()
    poleSlov(100) string
    zadaneSlovo string, s string, znovu string
    i int, poradi int, poslIndex int  //poslIndex: index poslední buňky pole s platným číslem
    i = 0: s = \": poradi = 0
    
    Do
        zadaneSlovo = Console.WriteLine(Zadej slovo, zadavani ukoncis prázdným ENTERem")
        if zadaneSlovo<> \" {
            s = s + Chr(10) + zadaneSlovo
            poleSlov(i) = zadaneSlovo
            i = i + 1
        }
    Loop Until zadaneSlovo = \"
    poslIndex = i - 1   //Tím se kompenzuje i = i + 1 za posledním číslerm


    znovu = Console.WriteLine(Zadej znovu jedno ze zadanych slov")
    For i = 0 To poslIndex
        if znovu = poleSlov(i) {
        poradi = i + 1
        }
    Next

    if poradi = 0 {
        Console.WriteLine("zadané slovo v sadě není"
    } else {
        Console.WriteLine("Zadana slova:" + Chr(10) + s + Chr(10) + "Slovo " + znovu + " bylo zadano jako " + poradi) + ". v poradi"
    }



    }
}
