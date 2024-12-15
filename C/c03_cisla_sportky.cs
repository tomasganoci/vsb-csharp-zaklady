using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {
    internal class c03_cisla_sportky {
        

//3)  Vytvořte program, který táhne 5 čísel Sportky (čísla 1 až 49). Čísla se (na rozdíl od Sportky) mohou opakovat.
//Moje poznámky: dává rozsah už do proměnné, já dávám celý vzorec do smyčky - zbyrčnš to furt ve smyčce počítá.


    cisloSportky string
    i byte, rozsah byte
    min int, max int


    min = 1
    max = 49
    rozsah = (max - min + 1) + min

    cisloSportky = \"
    for i = 0 To 4
        cisloSportky = cisloSportky + Int(Rnd()* rozsah)) + ","
    Next
    Console.WriteLine("Rozsah: " + min) + " ->" + max) + Chr(10) + 
            "Tažených čísel:" + i) + Chr(10) + 
            "Vzorec: Int(Rnd() * (max - min + 1) + min))" + Chr(10) + 
            Chr(10) + 
            "Dnešní čísla ve sportce jsou:" + cisloSportky)

Sub main_puvodni()
    cisloSportky string
    i byte
    min int, max int


    min = 1
    max = 49
    
    cisloSportky = \"
    for i = 0 To 4
        cisloSportky = cisloSportky + Int(Rnd()* (max - min + 1) + min)) + ","
    Next
    Console.WriteLine("Rozsah: " + min) + " ->" + max) + Chr(10) + 
            "Tažených čísel:" + i) + Chr(10) + 
            "Vzorec: Int(Rnd() * (max - min + 1) + min))" + Chr(10) + 
            Chr(10) + 
            "Dnešní čísla ve sportce jsou:" + cisloSportky)


//Řešení:
//c03: Vytvořte program, který táhne 5 čísel Sportky (čísla 1 až 49).
//Čísla se (na rozdíl od Sportky) mohou opakovat.

Sub main_reseni()
  i byte, rozsah byte
  tah float
  s string


  s = "Cisla sportky:  "
  rozsah = 49 - 1 + 1
  for i = 1 To 5
    tah = Int(Rnd()* rozsah) + 1
    s = s + tah) + ",  "
  Next
  MsgBox s


    }
}
