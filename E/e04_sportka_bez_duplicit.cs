using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace E {
    internal class e04_sportka_bez_duplicit {
        

//4) Upravte program pro Sportku (c3) tak, aby se tažená čísla nemohla opakovat.
//Testujte na větším počtu tahů, aby se opakování projevilo.
//Ještě lépe se projeví, pokud budete testovat na hodech kostkou (1-6), také nemá padnout stejné číslo dvakrát.
//Srovnejte s e2): tam se zjišťuje, kolikrát které číslo padlo.
//A nyní se má zajistit, aby vícekrát nepadlo.
//Pokud padne, hod se opakuje.
//Tento program je dost obtížný.
//Pokud zabere neúměrně hodně času, tak jej nechte až na druhou etapu přípravy, tedy po prvním vstupním testu.
//Moje poznámky: tenhle příkad je na mě moc těžky..., nechal jsem si ho na konec...,
//konečně jsem to vyřešil tím stylem, že to neustále prohledává tažené hodnoty dokud nejsou všechny neduplicitní


    Const maxCisel = 49
    Const pocetTazenych = 5
    cislaSportky(100) int, tazenaCisla(1 To pocetTazenych) int
    i byte, posledniIndex byte, d byte //"d" je počítadlo duplicity
    soupisTazenych string


    for i = i To maxCisel
        cislaSportky(i) = i
    Next i

    Randomize
//    i = 1
    soupisTazenych = \"
    for i = 1 To pocetTazenych
//    Do
        tazenaCisla(i) = cislaSportky(Int(Rnd()* (maxCisel + 1 - 1) + 1))
        for d = 1 To pocetTazenych
            if i<> d  && tazenaCisla(i) = tazenaCisla(d) {
                tazenaCisla(i) = cislaSportky(Int(Rnd() * (maxCisel + 1 - 1) + 1))
                d = 0
            }
        Next d
        soupisTazenych = soupisTazenych + tazenaCisla(i)) + ","
//        i = i + 1
//    Loop While i <> 50
    Next i
    MsgBox ("Tažená čísla:" + soupisTazenych)



//Řešení:
//e4: Upravte program pro Sportku (c3) tak, aby se tažená čísla nemohla opakovat.
//Testujte na větším počtu tahů, aby se opakování projevilo.
//ještě lépe se projeví, pokud budete testovat na hodech kostkou (1-6), také nemá padnout stejné číslo dvakrát
SportkaBezOpakovani()
    Const POCET_TAHU = 5
    tahy(POCET_TAHU - 1) byte
    i byte, j byte
    s string
    
    //tahy(0) = Round(Rnd() * 48) + 1        //zdánlivě chodí, ale první a poslední číslo padá je v poloviční četnosti oproti jiným číslům
    tahy(0) = Int(Rnd()* 49) + 1           //všimněte si, že čísla 1 až 49 padají, když se při použití Round násobí *48. Při Int *49
                                                //testovat na  * 6 místo * 49
    s = "0 " + tahy(0))
    i = 0
        
    Do
        i = i + 1
        //tahy(i) = Round(Rnd() * 48) + 1        //zdánlivě chodí, ale první a poslední číslo padá je v poloviční četnosti oproti jiným číslům
        tahy(i) = Int(Rnd()* 49) + 1           //všimněte si, že čísla 1 až 49 padají, když se při použití Round násobí *48. Při Int *49
                                                //testovat na  * 6 místo * 49
        s = s + Chr(10) + i) + " " + tahy(i))
        for j = 0 To i - 1
            if tahy(j) = tahy(i) {
                s = s + " opakovat"
                i = i - 1
                Exit for
            }
        Next j
    Loop While i<POCET_TAHU - 1


    MsgBox s




    }
}
