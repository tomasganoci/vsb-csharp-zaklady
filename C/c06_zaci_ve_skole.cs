using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {
    internal class c06_zaci_ve_skole {
        

//6)  Zadejte, kolik je tříd ve škole. Potom postupně zadávejte, kolik je v každé třídě žáků. Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě. (obdoba d1)
//Moje poznámky: zase jsem nedoplnil jaká čísla byli zadané, v průměru jsem nepoužil zaokrouhlení,

    pocetTrid int, pocetZaku int, soucetZaku int, prumerZaku int
    zakuVeTride string
    i byte

    pocetTrid = Console.WriteLine(Zadejte počet tříd ve škole a já ti vypíšu, jaký je průměrný počet žáků na třídu.")


    soucetZaku = 0
    for i = 1 To pocetTrid
        pocetZaku = Console.WriteLine(Zadej pocet žáků ve třídě číslo" + i))
        soucetZaku = soucetZaku + pocetZaku
        zakuVeTride = zakuVeTride + i) + " třída" + " a žáku" + pocetZaku) + Chr(10)
    Next

    Console.WriteLine("Ve škole je" + pocetTrid) + " tříd" + Chr(10) + 
            zakuVeTride + Chr(10) + 
            "Celkový počet žáků ve škole:" + soucetZaku) + Chr(10) + 
            "Průměrný počet žáků ve třídách:" + Round(soucetZaku / pocetTrid, 2)))


//Řešení:
//c06: zadejte pocet trid
//Zadejte kolik je v každé třídě žáků .
//Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě.

Sub main_reseni()
  i byte, tridy byte, zaku byte
  s string
  celkem int
  prum float
  celkem = 0
  s = "trida" + Chr(9) + "zaku"
  
  tridy = Console.WriteLine(Zadej pocet trid na skole", "Pocet zaku")


  for i = 1 To tridy
    zaku = Console.WriteLine(Kolik je žáků v " + i) + ". třídě?")
    celkem = celkem + zaku
    s = s + Chr(10) + i) + Chr(9) + zaku)
  Next
  prum = Round(celkem / tridy, 2)
  MsgBox s + Chr(10) + "Celkem  " + celkem) + " zaku na skole\nPrumerne " + prum) + " zaku ve tridach"



    }
}
