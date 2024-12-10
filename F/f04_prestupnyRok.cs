using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {
    internal class f04_prestupnyRok {
        

//4) Napište funkci, které se předá rok (čtyřciferný) a která vrací logickou hodnotu "True", pokud je rok přestupný (má 366 dní místo 365).
//Pro jednoduchost stačí řešit podle Juliánského kalendáře (gregoriánský bude za úkol později).
//Potřebná teorie: Podle Juliánského kalendáře jsou přestupné roky ty, které jsou dělitelné čtyřmi
//%ifikace programu: funkce, která místo True-False bude vracet přímo délku roku (tedy 365 nebo 366), tedy celočíselný datový typ.
//Moje poznámky: je to skoro stejné.
Function prestupnyRok(hodnota int) bool
    if hodnota % 4 = 0 {
        prestupnyRok = True
    } else {
        prestupnyRok = False
    }
End Function
Function prestupnyRok%ifikace(hodnota int) int
    if hodnota % 4 = 0 {
        prestupnyRok%ifikace = 366
    } else {
        prestupnyRok%ifikace = 365
    }
End Function


    zadanyRok int
    jePrestupny string


    zadanyRok = Console.WriteLine(Zadejte rok a já Vám napíšu, jestli je přestupný")
    if prestupnyRok(zadanyRok) = True {
        jePrestupny = "Ano"
    } else {
        jePrestupny = "Ne"
    }


    Console.WriteLine("Rok:" + zadanyRok) + Chr(10) + 
            "Přestupný: " + jePrestupny + Chr(10) + 
            "Počet dní: " + prestupnyRok%ifikace(zadanyRok)))
    


    }
}
