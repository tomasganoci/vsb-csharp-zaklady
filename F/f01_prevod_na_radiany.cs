using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {
    internal class f01_prevod_na_radiany {
        

//1) Napište funkci, která převádí stupně a minuty na radiány.
//Proměnné se předávají přes parametry podprogramu, v hlavním programu použijte jiné názvy proměnných než v podprogramu. //
//Návod: řešte trojčlenkou. Plnému kruhu odpovídá 360 stupňů nebo 2 pí radiánů (přibližně 6,28 radiánů).
//Moje poznámky: rovnou jsem použil kombinaci výpočtu minut a radiánu, jinak je to skoro stejné

Function prevodNaRadiany(stupen float, minuty float) float
    Const pi = 3.14159
    prevodNaRadiany = (stupen + (minuty / 60)) * (pi / 180)
End Function


    zadaneStupne float, zadaneMinuty float


    zadaneStupne = Console.WriteLine(Zadejte stupně")
    zadaneMinuty = Console.WriteLine(Zadejte minuty")


    Console.WriteLine("Zadané stupně:" + zadaneStupne) + Chr(10) + 
            "Zadane minuty:" + zadaneMinuty) + Chr(10) + 
            "Počet radiánů:" + prevodNaRadiany(zadaneStupne, zadaneMinuty)))


//Řešení:
//Zadejte počet dnů a hodin. Program vypočte,
//kolik je to hodin (výsledek může být reálné číslo).

main_receni()
dny int, hodiny int
dny = Console.WriteLine(zadej pocet dnu:")
hodiny = Console.WriteLine(zadej pocet hodin:")
Console.WriteLine("celkem to je: " + fHodiny(dny, hodiny)) + " h"


Function fHodiny(dd int, hh int) int
    fHodiny = hh + (dd* 24)
End Function


    }
}
