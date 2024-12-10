using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {
    internal class c01_sinus {
        

//1)  Vypište tabulku x funkce sinus(x) pro x od 0 do 2*PI s krokem 0,1. Výpis bude vypadat např. takto:
//Sin(0, 0) = 0
//sin(0,1) = 0,0998
//atd.
//Nevadí, když místo 0,0998 bude ,0998
//Moje poznámky: špatně jsem pochopil zadání a tak jsem nedal do 2* PI ale do 2. asi "krok" je lepší na pochopení, protože se liší od "index",


    sinus string
    i float
    Const pi = 3.14159


    sinus = \"
    For i = 0 To 2 * pi Step 0.1 //i = radiany
        sinus = sinus + "Sin (" + Round((i), 1)) + " ) = " + Round(Sin(i), 4)) + Chr(10)
    Next
    Console.WriteLine(sinus)


//Řešení:
//c01) Vypište tabulku funkce sinus od 0 do 2*PI s krokem 0,1.
//
Sub main_reseni()
  krok float
  s string
  Const pi = 3.14159
  i int

  s = \"
  For krok = 0 To 2 * pi Step 0.1
      s = s + "sin " + Round(krok, 2)) + Chr(9) + "je " + Round(Sin(krok), 4)) + Chr(10) //Chr(9) je tabulátor
  Next
  MsgBox s

  //Druhá možnost, počitadlo je celočíselné (obvykle se tomu dává přednost)

  s = \"
  For i = 0 To(10 * 2 * pi)
      s = s + "sin " + Round(i / 10, 2)) + Chr(9) + "je " + Round(Sin(i / 10), 4)) + Chr(10) //Chr(9) je tabulátor
  Next
  MsgBox s



    }
}
