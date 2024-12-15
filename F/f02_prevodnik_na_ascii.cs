using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {
    internal class f02_prevodnik_na_ascii {
        

//2)  Napište funkci, které se zadá znak a která vrátí jeho ASCII hodnotu.  (příliš lehké)
//Moje poznámky: skoro stejné, druhá možnost mi příjde asi více náročnější na proce.

    zadanyZnak string


    zadanyZnak = Console.WriteLine(Zadejte znak a já ti vypíšu jeho ASCII hodnotu")
    Console.WriteLine("Zadaný znak:" + zadanyZnak + Chr(10) + 
            "ASCII hodnota:" + vratASCII(zadanyZnak)))


Function vratASCII(ascii string) byte
    vratASCII =c(ascii)
End Function

//Řešení:
//f02) Napište funkci, které se zadá znak a která vrátí jeho ASCII hodnotu.

main_reseni()
    znak string, ascii byte
    znak = Console.WriteLine(Zadej znak!")
    ascii =ciiHodnota(znak)
    Console.WriteLine("ASCII hodnota zadaneho znaku " + znak + " je " + ascii), vbInformation

    ascii =ciiHodnota2(znak)
    Console.WriteLine("ASCII hodnota zadaneho znaku " + znak + " je " + ascii), vbInformation


FunctionciiHodnota(zadanyZnak string) byte
   ciiHodnota =c(zadanyZnak)
End Function
//Druhá možnost: kdybychom se chtěli vyhnout hotové funkcic
FunctionciiHodnota2(zadanyZnak string) byte
    i byte
    for i = 32 To 254
        if Chr(i) = zadanyZnak {
           ciiHodnota2 = i
            Exit for  //ukončuje smyčku, neboť se nemusí už dál kontrolovat
        }
    Next
End Function



    }
}
