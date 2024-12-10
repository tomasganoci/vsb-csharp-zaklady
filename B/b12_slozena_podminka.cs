using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {
    internal class b12_slozena_podminka {
        

//b12) Program se zeptá, zda je den a zda je horko (odpověď a/n).
//Pouze v případě obou odpovědí kladných vám navrhne jít si zaplavat.
//Použijte jen jeden příkaz IF (ale se složenou podmínkou).
//Předpokládejme, že uživatel bude uvědomněle zadávat malá písmena.
//moje poznámky: nepočítal jsem při podmínkách s další možností a/n, nepočítám s možností, že by dal někdo velké písmeno,

    denSvetlo string, jeHorko string


    denSvetlo = Console.WriteLine(Je venku ještě světlo? (a/n)")
    jeHorko = Console.WriteLine(Je venku horko? (a/n)")


    if(denSvetlo = "a") And(jeHorko = "a") {
        Console.WriteLine("Tak si pojď zaplavat!")
    } else {
        Console.WriteLine("Tak raději zůstaň doma")
    }




//Řešení:
//b12) Program se zeptá, zda je den a zda je horko.Pouze v případě obou odpovědí kladných vám navrhne jít si zaplavat.Použijte jen jeden příkaz IF(ale se složenou podmínkou).
//
//  jeDen string, jeHorko string
//
//  jeDen = Console.WriteLine(Je den? (a/n) ")
//  jeHorko = Console.WriteLine(Je horko? (a/n)")
//
//  if jeDen = "a" And jeHorko = "a" {
//    Console.WriteLine("Jdi si zaplavat"
//  } else {if jeDen = "a" And jeHorko = "n" {
//    Console.WriteLine("dnes neni dobre pocasi na plavani"
//  } else {if jeDen = "n" {
//    Console.WriteLine("jdi spat, je noc"
//  } else {
//    Console.WriteLine("neplatna volba"
//  }
//
//
//
//b12: Program se zeptá, zda je den a zda je horko.
//Pouze v případě obou odpovědí kladných vám navrhne jít si zaplavat.
//Použijte jen jeden příkaz IF(ale se složenou podmínkou).
//
//
//  den string
//  h string
//  den = Console.WriteLine(Je den? [A/N] ", "Jit plavat")
//  h = Console.WriteLine(je horko? [A/N] ", "Jit plavat")
//  if (den = "A" Or den = "a") And (h = "A" Or h = "a") {
//    Console.WriteLine("Bez si zaplavat", vbInformation, "vysledek"
//  } else {
//    }
//

    }
}
