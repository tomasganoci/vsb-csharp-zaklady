using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {
    internal class d09_teplota_vody {
        

//9) Uživatel bude zadávat postupně teploty vody s přesností na desetinu stupně.
//Zadávání ukončí zadáním teploty přesahující 100° (tato teplota je ale také součástí dat!).
//Zadávání končí, protože pak už voda vyvřela.
//Program zobrazí zadané teploty, minimální teplotu a kolikátá v pořadí tato teplota byla.
//A také průměr teplot
//Moje poznámky: pořadí jsem mohl vyřešit úplně jednoduše a nemusel jsem do toho tahat proměnnou "i", nedošlo mi, že už by nemělo být součásti dat teplota více než 100,


    zadanaTeplota float, minTeplota float, soucetTeplot float
    zadaneTeploty string
    i byte
    poradi int


    zadaneTeploty = \"
    i = 0
    Do
    zadanaTeplota = Console.WriteLine(Zadejte postupně teplotu vody na desetinu stupně.\nJakmile voda vyvře, tak se ukončím.")
    zadaneTeploty = zadaneTeploty + Round(zadanaTeplota, 1)) + ","
    if i = 0 {
        minTeplota = zadanaTeplota //inizializace teploty
        poradi = i + 1
    } else {if zadanaTeplota<minTeplota {
        minTeplota = zadanaTeplota
        poradi = i + 1
    }
    soucetTeplot = soucetTeplot + zadanaTeplota
    i = i + 1
    Loop Until zadanaTeplota >= 100


    MsgBox ("Zadané hodnoty:" + zadaneTeploty + Chr(10) + 
            "Minimální teplota:" + Round(minTeplota, 1)) + Chr(10) + 
            "Pořadí minimální teploty:" + poradi)) + Chr(10) + 
            "Průměr teplot:" + Round(soucetTeplot / i, 1)) + " (" + soucetTeplot) + " /" + i) + " )"



//Řešení:

//d09) Uživatel bude zadávat postupně teploty s přesností na desetinu stupně.
//Zadávání ukončí zadáním teploty přesahující 100°
//(tato teplota je ale také součástí dat!). Program zobrazí zadané teploty, minimální teplotu
//a kolikátá v pořadí tato teplota byla. A také průměr teplot
main_reseni()
    teplota float, minT float, sum float
    i byte, poradi byte
    s string


    poradi = 0: i = 0: sum = 0
    Do
        teplota = Console.WriteLine(Zadej teplotu s přesností na desetinu stupně, teplota vetsi nez 100 zadavani ukonci")
        if i = 0 {
            minT = teplota        //lepší by bylo inicializovat minimum před smyčkou
            poradi = 1
        }
        //if teplota <= 100 {             //toto ne, protože i tentokrát poslední hodnota patří do platných dat
        s = s + Chr(10) + teplota)
        i = i + 1
        sum = sum + teplota
        if teplota<minT {
            minT = teplota
            poradi = i
        }
        //}
    Loop Until teplota > 100    //nebo Loop While teplota <= 100
    
    s = "Zadané teploty:" + s + Chr(10) + "Nejnižší je " + minT) + "° a je " + poradi) + ". v pořadí."
    MsgBox s + Chr(10) + "průměrná teplota: " + Round(sum / i, 1))
    


    }
}
