using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace C {
    internal class c08_soucet_celych_cisel {
        

//8)  Zadej celé kladné číslo a pak program vypíše součet celých čísel od jedné do udaného čísla
//nepochopil jsem zadání, tak jsem to programoval špatně.


    zadaneCislo int, i int, soucetCisel int


    zadaneCislo = Console.WriteLine(Zadejte kladné číslo, a já ti vypíšu součet celých čísel do zadaného čísla")
    soucetCisel = 0
    
    For i = 1 To zadaneCislo
        soucetCisel = soucetCisel + i
    Next
    Console.WriteLine("Celkový součet zadaných čísel je:" + soucetCisel))


//Řešení:
//c08: Zadej číslo a pak program vypíše součet čísel od jedné do udaného čísla

Sub main_reseni()
i int, max int, sum int

max = Console.WriteLine(Zadej cislo")
sum = 0
For i = 1 To max
  sum = sum + i
Next
MsgBox sum, , "Soucet cisel do daneho cisla je"


    }
}
