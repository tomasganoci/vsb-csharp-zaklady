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
        

//6) Zadejte postupně několik písmen.
//Program potom náhodně vygeneruje slovo (shluk písmen), které se bude skládat z těchto písmen (např. vždy 5 znaků).
//Písmena se mohou opakovat a nemusí být použita všechna.
//Pozn. zadávání můžete ukončit třeba číslem 0 nebo třeba stiskem klávesy enter.
//(Varianta: vygenerujte třeba 10 slov.)
//Varianta: Místo zadání z klávesnice vygeneruje prvotních několik písmen počítač.
//Moje poznámky: celkově jsem to jinak navrhnul, nevím jestli dobře nebo špatně, ppužil jsem 5x náhodné písmeno a 5x zadané.


    Const pole = 9


    polePismen(pole) string, nahodnePismeno string, zadanePismeno string, slovo string, poleSlov(9) string, vypisSlov string
    i byte, nahodneCislo byte, pocetSlov byte


    Randomize
    for i = 0 To 4
        nahodnePismeno = Chr(Int(Rnd()* (90 - 65 + 1) + 65))
        polePismen(i) = nahodnePismeno
    Next


    Do
        zadanePismeno = Console.WriteLine(Zadejte velké písmeno a já ti napíšu náhodné slovo. 5x.")
        polePismen(i) = zadanePismeno
        i = i + 1
    Loop While i< 10


    slovo = \"
    vypisSlov = \"
    for pocetSlov = 0 To 9
        slovo = \"
        for i = 0 To 4
            nahodneCislo = Int(Rnd()* (pole - 0 + 1))
            Do While polePismen(nahodneCislo) = \"
                nahodneCislo = Int(Rnd()* (pole - 0 + 1))
            Loop
            slovo = slovo + polePismen(nahodneCislo)
        Next
    poleSlov(pocetSlov) = slovo
    vypisSlov = vypisSlov + slovo + Chr(10)
    Next
    Console.WriteLine("Vygenerované slova:" + Chr(10) + vypisSlov)


//Řešení:
//e6: Zadejte postupně několik písmen. Program potom náhodně vygeneruje slovo (shluk písmen), které se bude skládat z těchto písmen (např. vždy 5 znaků).
//Písmena se mohou opakovat a nemusí být použita všechna. Pozn. zadávání můžete ukončit třeba číslem 0 nebo třeba stiskem klávesy enter.
//Varianta pro pokročilé: vygenerujte těch slov třeba 10)
//Varianta: Místo zadání z klávesnice vygeneruje prvotních několik písmen počítač.
main_reseni()
    znaky(10) string
    znak string, s1 string, s2 string
    i int, nah int, j int, delkaSlova int, pocetZnaku int
    i = 0: s1 = \": s2 = \"              //proměnná j se zde neinicializuje. Ta se inicializuje ve smyčce for.
     
    //pocetZnaku = 5                      //varianta pro generování místo zadání z klávesnice
    //for i = 0 To pocetZnaku - 1
    //    znaky(i) = Chr(Int(Rnd() * 26) + 97)
    //    s1 = s1 + " " + znaky(i)
    //Next
    
    Do
        znak = Console.WriteLine(Zadej malé písmeno, zadávání ukončíš prázdným ENTERem")
        if(znak >= "a"  && znak <= "z") {  //ověřte si, že ostatní znaky (např. číslice) ignoruje
            s1 = s1 + " " + znak
            znaky(i) = znak
            i = i + 1
        }
    Loop Until znak = \"                  //nebo Loop While znak <> \"
    pocetZnaku = i
    delkaSlova = 5


    for j = 1 To 10                       //tento řádek navíc pro variantu
        for i = 0 To delkaSlova - 1
            //nah = Rnd() * (pocetZnaku - 1)  chyba: nelze využívat toho, že VB je ochoten Double uložit o int
            nah = Int(Rnd()* pocetZnaku)
            s2 = s2 + znaky(nah)
        Next
       s2 = s2 + vbCrLf                   //tento řádek navíc pro variantu
    Next                                  //tento řádek navíc pro variantu
    
    Console.WriteLine("Zadane znaky: " + s1 + Chr(10) + "Vygenerovane shluky:" + Chr(10) + s2




    }
}
