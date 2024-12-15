using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {
    internal class d02_uctenky {
        

//2) Máte schované účtenky z různých nákupů, nevíte ale, kolik účtenek je. Proto částky na účtenkách budete zadávat postupně, jako poslední zadáte nulu.
//Program spočítá, kolik jste utratili a zároveň oznámí, kolik nákupů přesáhlo částku 100 Kč.
//Moje poznámky: doplnil jsem více proměnných a více údajů, použíl jsem u "while" nerovná se tedy <> a dává to větší logiku, protže musím zadat kladné číslo, když dám ">",
//               použil jsem exit Do - což jsem asi neměl, když jsem to neměl v učení,

    castkaUctenky float, soucetUctenek float, uctenkyNadHodnotou float
    i int, pocetNadHodnotou int
    uctenky string


    uctenkyNadHodnotou = 100
    pocetNadHodnotou = 0
    soucetUctenek = 0
    uctenky = \"
    
    Do
        i = i + 1
        castkaUctenky = Console.WriteLine(Zadejte částku z účtenky číslo" + i) + Chr(10) + 
                                 "Počítání ukončíte zadáním \"0\".")
        if castkaUctenky = 0 {
            Exit Do
        }

        soucetUctenek = soucetUctenek + castkaUctenky
        uctenky = uctenky + "Účtenka číslo" + i) + " je na částku" + castkaUctenky)
        if(castkaUctenky > uctenkyNadHodnotou) {
            pocetNadHodnotou = pocetNadHodnotou + 1
            uctenky = uctenky + " - Tato účtenka je nad" + uctenkyNadHodnotou) + " Kč" + Chr(10)
        } else {
             uctenky = uctenky + Chr(10)
        }
    Loop While castkaUctenky<> 0
    
    Console.WriteLine(uctenky + 
            Chr(10) + 
            "Celkový součet účtenek:" + soucetUctenek) + Chr(10) + 
            "Počet účtenek nad hodnotu" + uctenkyNadHodnotou) + ":" + pocetNadHodnotou))
        


//Řešeni:

//d02: Máte schované účtenky z různých nákupů, nevíte ale, kolik účtenek je.
//Proto částky na účtenkách budete zadávat postupně, jako poslední zadáte nulu.
//Program spočítá, kolik jste utratili a zároveň oznámí, kolik nákupů přesáhlo částku 100 Kč.

main_reseni()
  castka float, suma float
  pocet100 byte


  suma = 0
  pocet100 = 0
  Do
    castka = Console.WriteLine(Zadej částku na účtence (Kč)   [0=konec]")
    suma = suma + castka
    if castka > 100 {
        pocet100 = pocet100 + 1
    }
  Loop While castka > 0
  Console.WriteLine("Celkem utraceno  " + suma) + " kc" + Chr(10) + pocet100) + " x nákup větší než 100 Kč"


    }
}
