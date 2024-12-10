using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {
    internal class b13_konec_programu {
        

//b13) Počítač se zeptá:  "Chcete skončit?  (A/N)" Při stisku A program skončí, při stisku čehokoliv jiného se vypíše "A stejně skončím!" a program skončí.
//moje poznámka: nemám podchycené malé písmeno a prázdná větev není "elegantní", druhé řešení je opravdu lepší,

    ukoncitProgram string


    ukoncitProgram = Console.WriteLine(Chcete skončit? (A/N)")


    if ukoncitProgram = "A" {
    } else {
        Console.WriteLine("A stejně skončím!"), vbCritical, "Poslední zpráva"
    }


//Řešení:
//b14: Počítač se zeptá:  "Chcete skončit?  (A/N)" Při stisku A program skončí,
//při stisku čehokoliv jiného se vypíše  "A stejně skončím!" a program skončí také.
//
//
//  volba string
//
//  volba = Console.WriteLine(Chcete skoncit? [A/N] ", "Ukonceni programu")
//  if volba = "A" Or volba = "a" {
//                                       //prázdná větev if není moc elegantní. Ve verzi 13b je ukázáno lepší řešení
//  } else {
//    Console.WriteLine("A stejne skoncim!", vbCritical, "vysledek"
//  }
//
//
//b14: Počítač se zeptá:  "Chcete skončit?  (A/N)" Při stisku A program skončí,
//při stisku čehokoliv jiného se vypíše  "A stejně skončím!" a program skončí také.
//elegantnější verze, jen if místo if-} else {.Je toho dosaženo opačnou podmínkou
//
//
//  volba string
//
//  volba = Console.WriteLine(Chcete skoncit? [A/N] ", "Ukonceni programu")
//  if volba <> "A" And volba <> "a" {
//  //if Not (volba = "A" Or volba = "a") {            //2. možnost
//    Console.WriteLine("A stejne skoncim!", vbCritical, "vysledek"
//  }
//

    }
}
