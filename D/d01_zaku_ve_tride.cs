using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {
    internal class d01_zaku_ve_tride {
        

//1) Zadejte postupně, kolik je v každé třídě žáků (0=konec).
//Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě.
//Ověřte, že nula do platných dat nepatří.
//Nesmí se tedy stát, že při zadání 30 a 0 (tedy jen jedna třída a to s 30 žáky) vyjde průměrný počet žáků 15 (omylem se uvažovaly dvě třídy, jedna má 30 a druhá 0 žáků)
//Moje poznámky: počet žáku a tříd jsem dal int a mohl jsem dát byte, přepsal jsem proměnnou "trida" na pocetTrid", součet počtu žáků jsem mohl nechat v Do - 0 nevadí když se sečte
//               nevzal jsem v potaz, že by první číslo mohla být 0 a tak by byla škola prázdná, zahrnul jsem podmínky do DO, průměr jsem udělal přímo v MsgBox,


    zadanoZaku int
    poceTrid byte, pocetZaku byte
    zakuVeTride string


    poceTrid = 0
    pocetZaku = 0
    zakuVeTride = \"
    
    Do
        poceTrid = poceTrid + 1
        zadanoZaku = Console.WriteLine(Zadejte počet žáků ve tříde číslo: " + poceTrid) + Chr(10) + "Zadejte \"0\" pro ukončení.")
        if zadanoZaku = 0 {
            poceTrid = poceTrid - 1
        } else {
            zakuVeTride = zakuVeTride + "Třída:" + poceTrid) + " Počet dětí:" + zadanoZaku) + Chr(10)
            pocetZaku = pocetZaku + zadanoZaku
        }

    Loop While zadanoZaku<> 0
    
    MsgBox (zakuVeTride + Chr(10) + "Celkový počet žáků:" + pocetZaku) + Chr(10) + "Průměrný počet žáků ve třídě:" + Round(pocetZaku / poceTrid, 1)))
    


//Řešení:

//d01: Zadejte postupně, kolik je v každé třídě žáků (0=konec).
//Program spočítá, kolik je žáků v celé škole a průměrný počet žáků ve třídě.
//Ověřte, že nula do platných dat nepatří.
//Nesmí se tedy stát, že při zadání 30 a 0 (tedy jen jedna třída a to s 30 žáky)
//vyjde průměrný počet žáků 15 (omylem se uvažovaly dvě třídy, jedna má 30 a druhá 0 žáků)

Sub main_reseni()
  pocetTrid byte, pocetZaku byte
  suma int
  Prumer float


  pocetTrid = 0
  suma = 0
  Do
    pocetZaku = Console.WriteLine(Zadej pocet zaku ve tride [0=konec]")
    suma = suma + pocetZaku
    pocetTrid = pocetTrid + 1
  Loop While pocetZaku > 0
  if suma = 0 {
    Console.WriteLine("Škola je prádná."
  } else {
    Prumer = suma / (pocetTrid - 1)
    Console.WriteLine("Celkem  " + suma) + " žáků na škole\nPrůměrně  " + Prumer) + " žáků ve třídách"
  }




    }
}
