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
        

//8) Řadu slov z předchozího příkladu vypište v obráceném pořadí, a pak vypíše pouze sudá a pak pouze lichá slova.
//A předělejte příklady c) a d) na pole. Tedy nezpracovávejte je v první smyčce, ale až v druhé.
//Moje poznámky: zase jiný posledníIndex, jinak řešeno počítadlo, dává podmínku do "Do", což jsem si myslel, že je lepší, čím méně podmínek tím lépe, když to není třeba.


    slovaPole(1 To 100) string, zadaneSlovo string, vypisSlov string, vypisSude string, vypisLiche string
    i int
    posledniIndex byte

    i = 1
    Do
    zadaneSlovo = Console.WriteLine(Zadejte slovo. Ukončíte tlačítkem \"Cancel\"")
    slovaPole(i) = zadaneSlovo
    posledniIndex = i - 1
    i = i + 1
    Loop While zadaneSlovo<> \"
    
    vypisSlov = "Pořadí obráceně      Slovo" + Chr(10)
    vypisSude = "Pořadí sudé      Slovo" + Chr(10)
    vypisLiche = "Pořadí liché      Slovo" + Chr(10)


    for i = posledniIndex To 1 Step -1
        vypisSlov = vypisSlov + i) + "                        " + slovaPole(i) + Chr(10)
        if i % 2 = 0 {
            vypisSude = vypisSude + i) + "                        " + slovaPole(i) + Chr(10)
        } else {
            vypisLiche = vypisLiche + i) + "                        " + slovaPole(i) + Chr(10)
        }
    Next

    Console.WriteLine(vypisSlov + Chr(10) + vypisSude + Chr(10) + vypisLiche)

//Řešení:
//e8: Řadu slov z předchozího příkladu vypište v obráceném pořadí,
//a pak vypíše pouze sudá a pak pouze lichá slova.
main_reseni()
    poleSlov(100) string
    vstup string, s string, sZpet string, sLicha string, sSuda string
    i int, j int, poslIndex int  //poslIndex: index poslední buňky pole s platným číslem
    i = 0: s = \": sZpet = \": sLicha = \": sSuda = \"
    
    Do
        vstup = Console.WriteLine(Zadej slovo, zadávání ukončíš prázdným ENTERem")  //nebo ENTERem
        if vstup<> \" {
            s = s + vbCrLf + vstup    //místo vbCrLf lze i Chr(10)
            poleSlov(i) = vstup
            i = i + 1
        }
    Loop Until vstup = \"
    poslIndex = i - 1   //Tím se kompenzuje i = i + 1 za posledním číslerm


    for i = poslIndex To 0 Step -1
        sZpet = sZpet + Chr(10) + poleSlov(i)
    Next

    for j = 0 To poslIndex
        if (j + 1) % 2 = 0 {
            sSuda = sSuda + Chr(10) + poleSlov(j)
        } else {
            sLicha = sLicha + Chr(10) + poleSlov(j)
        }
    Next

    Console.WriteLine("Zadana slova:" + s + Chr(10) + "Obraceny vypis:" + sZpet + Chr(10) + "Licha:" + sLicha + Chr(10) + "Suda:" + sSuda



    }
}
