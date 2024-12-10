using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {
    internal class d07_hod_kostkou_s_cilem {
        

//7) Program hází kostkou tak dlouho, dokud nepadne šestka. Potom vypíše, kolik hodů bylo potřeba.
//Moje poznámky: skoro stejné, až na vzorec hodu kostkou

    i byte
    hodKostkou float
    ciloveCislo int, min int, max int
    hozenaCisla string


    min = 1
    max = 6
    ciloveCislo = 6
    
    hozenaCisla = \"
    i = 0
    Do
    hodKostkou = Int(Rnd() * (max - min + 1) + min)
    hozenaCisla = hozenaCisla + hodKostkou) + ","
    i = i + 1
    Loop Until ciloveCislo = hodKostkou
    Console.WriteLine("Program musel hodit kostkou" + i) + "x" + Chr(10) + 
           "Hozené čísla:" + hozenaCisla)



//Řešení:

//d07: Program hází kostkou tak dlouho, dokud nepadne šestka.
//Potom vypíše, kolik hodů bylo potřeba.

Sub main_reseni()
  nah float
  i byte
  s string


  i = 0: s = \"
  Do
    nah = Int(Rnd() * 6 + 1)
    s = s + nah) + " "
    i = i + 1
  Loop Until nah = 6
  MsgBox s + Chr(10) + "Šestka padla na " + i) + ". pokus"


    }
}
