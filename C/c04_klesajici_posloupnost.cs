using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {
    internal class c04_klesajici_posloupnost {
        

//4)  Vypište klesající posloupnost čísel od 8 do -8.  Varianta: vypište stejnou posloupnost, ale pouze každé druhé (sudé) číslo. (Nepoužívejte if.)
//Moje poznámky: jen jsem doplnil nadpis okna,


    i int, min int, max int
    klesajiciCislo string, klesajiciSudeCislo string


    min = -8
    max = 8
    
    klesajiciCislo = \"
    For i = 8 To -8 Step -1
        klesajiciCislo = klesajiciCislo + i) + ", "
    Next

    klesajiciSudeCislo = \"
    For i = 8 To -8 Step -2
        klesajiciSudeCislo = klesajiciSudeCislo + i) + ", "
    Next

    Console.WriteLine("Vzorec: For i = 8 To -8 Step -1" + Chr(10) + 
            klesajiciCislo + Chr(10) + 
            Chr(10) + 
            "Vzorec: For i = 8 To -8 Step -2" + Chr(10) + 
            klesajiciSudeCislo), , "Posloupnost 8 až -8"



//Řešení:

//c04: Vypište klesající posloupnost čísel od 8 do -8.

Sub main_reseni()
  i int
  s string


  s = \"
  For i = 8 To -8 Step -1
    s = s + Chr(10) + i)
  Next
  MsgBox s, , ("posloupnost 8 az -8")


//Varianta: vypište stejnou posloupnost, ale pouze každé druhé (sudé) číslo. (Nepoužívejte if.)
Sub main_reseni2()
  i int
  s string


    s = \"
    For i = 8 To -8 Step -2
        s = s + Chr(10) + i)
    Next
    Console.WriteLine(s)




    }
}
