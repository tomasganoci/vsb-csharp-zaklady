using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {
    internal class c05_rozdil_v_prumeru {
        

//5)  Vygenerujte 20 celých náhodných celých čísel v rozsahu 10..50. Zjistěte, o kolik se jejich střední hodnota (průměr) liší od středu intervalu, tedy od 30.
//Moje poznámky: doplněná větší mezera mezi čísly, doplněn v msgboxu index, v řešní je pouze průměr rozdílu v intervalu, já ho doplnil ke každému číslu, ještě doplním průměr rozdílu celkově


    nahodneCisloRetezec string
    min int, max int, prumerMinMax int, nahodneCislo int, scitaniRozdilu int, rozdil int
    i byte, delitelPrumeru byte


    min = 10
    max = 50
    prumerMinMax = (min + max) / 2
    
    nahodneCisloRetezec = \"
    For i = 1 To 20
        nahodneCislo = Rnd() * (max - min + 1) + min
        rozdil = prumerMinMax - nahodneCislo
        nahodneCisloRetezec = nahodneCisloRetezec + i) + " číslo:" + nahodneCislo) + "            Rozdíl:" + rozdil) + Chr(10)
        scitaniRozdilu = scitaniRozdilu + rozdil
        delitelPrumeru = delitelPrumeru + 1
    Next

    Console.WriteLine("Rozsah:" + min) + "->" + max) + Chr(10) + 
            "Průměr rozsahu:" + prumerMinMax) + Chr(10) + 
            Chr(10) + 
            nahodneCisloRetezec + Chr(10) + 
            "Průměr od středu rozdílu: " + scitaniRozdilu / delitelPrumeru))


//Řešení:

//c05: Vygenerujte 20 celých náhodných čísel v rozsahu 10..50.
//Zjistěte, o kolik se jejich střední hodnota (průměr) liší od středu intervalu, tedy od 30.

Sub main_reseni()
  i byte, nah byte, rozsah byte
  s string
  sum int
  rozdil float


  sum = 0
  s = "                     cislo"
  rozsah = 50 - 10 + 1
  For i = 1 To 20
    nah = Int(Rnd()* rozsah) + 10
    sum = sum + nah
    s = s + Chr(10) + i) + " cislo je        " + nah)
  Next
  rozdil = sum / 20 - 30
  MsgBox s + Chr(10) + "jejich prumer se lisi o  " + rozdil) + "  od stredu intervalu"



    }
}
