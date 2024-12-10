using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {
    internal class c11_ascii_seznam {
        

//11) Tabulka ASCII: zobrazit v  MsgBoxu v levém sloupci čísla např. 65 až 100 a v pravém příslušný znak.
//Moje poznámky: nemám "hlavičku", zapomněl jsem inicializaci asci,

    asci string
    i byte


    asci = "ASCII     znak" + Chr(10)
    For i = 65 To 100
        asci = asci + i) + "            " + Chr(i) + Chr(10)
    Next
    Console.WriteLine(asci)


//Řešení:
//c11: Tabulka ASCII: zobrazit v  msgBoxu v levém sloupci čísla např. 65 až 100 a v pravém příslušný znak.

Sub main_reseni()
  i byte
  znak string, s string


  s = "ASCII   znak" + Chr(10)
  For i = 65 To 100
    znak = Chr(i)
    s = s + i) + "       " + znak + Chr(10)
  Next
  MsgBox s, , "Tabulka ASCII [65-100]"



    }
}
