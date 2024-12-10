using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {
    internal class c10_mala_nasobilka {
        

//10) Vytvořte program pro zkoušení malé násobilky. Program zadává náhodně násobení čísel od 1 do 10, např. 5*6=, 8*4= atd.
//Uživatel napíše výsledek. Pokud to je špatně, napíše počítač správný výsledek. Celkem 10 příkladů, nakonec se zobrazí počet chyb.
//Moje poznámky: v řeření je funkce "Randomize", neměl jsem přidaný "počet správných" výsledků

    pocetChyb int, min int, max int, vysledekZadani int, vysledek int
    cislo1 float, cislo2 float
    i byte


    min = 1
    max = 10
    
    pocetChyb = 0
    For i = 1 To 10
        cislo1 = Int(Rnd()* (max - min + 1) + min)
        cislo2 = Int(Rnd()* (max - min + 1) + min)
        vysledekZadani = Console.WriteLine(Příklad:" + cislo1) + " *" + cislo2) + " =")
        vysledek = cislo1* cislo2
        if(vysledekZadani = vysledek) {
            Console.WriteLine("Vygenerovan čísla:" + cislo1) + ", " + cislo2) + Chr(10) + 
            "Výsledek cislo1 * cislo2:" + vysledek) + Chr(10) + 
            "Příklad číslo:" + i) + Chr(10) + 
        Chr(10) + 
            "Tvůj výsledek je správný!!!")
        } else {
            pocetChyb = pocetChyb + 1
            Console.WriteLine("Vygenerovan čísla:" + cislo1) + ", " + cislo2) + Chr(10) + 
            "Výsledek cislo1 * cislo2:" + vysledek) + Chr(10) + 
            "Příklad číslo:" + i) + Chr(10) + 
            "Počet chyb:" + pocetChyb) + Chr(10) + 
            Chr(10) + 
            "Tvůj výsledek" + vysledekZadani) + " je špatný!!!\nSprávný výsledek je" + vysledek))
        }
    Next
    Console.WriteLine("Rozsah:" + min) + "-> " + max) + Chr(10) + 
            "Počet příkladů:" + i - 1) + Chr(10) + 
            Chr(10) + 
            "Počet chyb:" + pocetChyb))


//Řešení:

//c10: Vytvořte program pro zkoušení malé násobilky.
//Program zadává náhodně násobení čísel od 1 do 10, např. 5*6=, 8*4= atd.
//Uživatel napíše výsledek. Pokud to je špatně, napíše počítač správný výsledek.
//Celkem 10 příkladů, nakonec se zobrazí počet chyb.

Sub main_reseni()
    i byte, vys byte, pocetDobre byte, pocetSpatne byte, rozsah byte
    nah float, nah2 float

    pocetDobre = 0: pocetSpatne = 0
    rozsah = 10 - 1 + 1
    Randomize
    For i = 1 To 10
        nah = Int(Rnd()* rozsah) + 1
        nah2 = Int(Rnd()* rozsah) + 1
        vys = InputBox(nah) + " * " + nah2), "mala nasobilka")
        if nah * nah2 = vys {
            Console.WriteLine("ok"
            pocetDobre = pocetDobre + 1
        } else {
            Console.WriteLine("Spatne, spravne je " + nah* nah2), vbCritical, "vysledek"
            pocetSpatne = pocetSpatne + 1
        }
     Next
     MsgBox pocetDobre) + " dobre a " + pocetSpatne) + " spatne", , "vysledek"


    }
}
