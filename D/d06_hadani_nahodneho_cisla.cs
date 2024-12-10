using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {
    internal class d06_hadani_nahodneho_cisla {
        

//6) Upraveno podle Doc. Homoly: Sestavte program, který si myslí (náhodně vygeneruje) celé číslo z intervalu <1,10>.
//Pak ho vy hádáte (zadáváte z klávesnice), dokud se nestrefíte.
//Počítač vypíše, na který pokus se to podařilo.
//Moje poznámka: dodělal jsem i podmínku, kdyý se něco zadá mimo rozsah, jiný postup řešení s méně detaily,


    nahodneCislo float
    zadaneCislo int, min int, max int
    pokus byte
    zadaneCisla string


    pokus = 0
    min = 1
    max = 10
    nahodneCislo = Int(Rnd()* (max - min + 1) + min)
    
    zadaneCisla = \"
    Do
    zadaneCislo = Console.WriteLine(Hádej číslo od 1 do 10, které si myslím. Pokračejeme dokud neuhádneš.", "Hádání čísel")
    if zadaneCislo >= min  && zadaneCislo <= max  && zadaneCislo<> nahodneCislo {
        Console.WriteLine("To není správně. Zkus to znovu!")
        zadaneCisla = zadaneCisla + zadaneCislo) + ","
        pokus = pokus + 1
    } else {if zadaneCislo<> nahodneCislo {
        MsgBox ("Zadal jsi číslo mimo rozsah!"), vbCritical, "Mimo rozsah"
    }
    Loop Until zadaneCislo = nahodneCislo
    Console.WriteLine("Uhádl jsi to!!! Je to číslo" + nahodneCislo) + ". Na" + pokus + 1) + " pokus" + Chr(10) + 
            "Použitá čísla:" + zadaneCisla + zadaneCislo))


//Řešení:

//d06: Program Doc. Homoly: Sestavte program, který si myslí (náhodně vygeneruje) celé číslo z intervalu <1,10>.
//Pak ho vy hádáte (zadáváte z klávesnice), dokud se nestrefíte. Počítač vypíše, na který pokus se to podařilo.

Sub main_reseni()
  nah byte, hadam byte, i byte


  i = 0
  nah = Int(Rnd()* 10 + 1)
  Do
    hadam = Console.WriteLine(Hádej číslo [1-10]")
    i = i + 1
  Loop Until nah = hadam
  Console.WriteLine("číslo " + nah) + " bylo uhádnuto na " + i) + ". pokus"


    }
}
