using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {
    internal class b10_odmocnina_zaporu {
        

//b10) Zadejte číslo. Počítač vypíše: "Odmocnina čísla ... je  ..." nebo oznámí, že odmocninu záporného čísla počítat nebude.
//moje poznámky: spletl jsem si odmocninu a mocninu, tak jsem místo 0.5 dal 2, do podmínkyj sme dal i 0, nevím jestli to je špatně nebo dobře.


    zadaneCislo float


    zadaneCislo = Console.WriteLine(Zadejte číslo a já ti napíšu, jaká je jeho odmocnina")


    if(zadaneCislo <= 0) {
        Console.WriteLine("Odmocninu z 0 nebo záporného čísla počítat nebudu!")
    } else {
        Console.WriteLine("Odmocnina čísla" + zadaneCislo) + " je" + zadaneCislo ^ 0.5))
    }



//Řešení:
//
//b10: Zadejte číslo.Počítač vypíše: "Odmocnina čísla ... je  ..." nebo oznámí,
//že odmocninu záporného čísla počítat nebude.
//
//
//  c float
//
//  c = Console.WriteLine(zadej cislo: ")
//  if (c < 0) {
//    Console.WriteLine("Zaporne cilo pocitat nebudu", vbCritical, "vysledek"
//  } else {
//    Console.WriteLine("odmocnina čísla " + c) + " je " + c ^ 0.5)
//  }
//
//

    }
}
