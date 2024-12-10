using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace B {
    internal class b06_rychlejsi_auto {
        

//b6)  První auto ujelo trasu s1 za čas t1 a druhé trasu s2 za čas t2. (údaje zadejte).
//Spočítejte průměrnou rychlost obou aut a vypište zprávu "... auto je o ... rychlejší".
//moje poznámky: zadal jsem jednotky v metrech a sekundách, nezaokrouhlil jsem, podmínky mám trochu jinak,


    s1 float, t1 float, s2 float, t2 float, prumer1 float, prumer2 float //s = délka trasy, t = čas trasy


    s1 = Console.WriteLine(Zadejte délku trasy pro první auto. (Zadejte v m/s)")
    t1 = Console.WriteLine(Zadejte čas, za kterou první auto ujelo trasu. (Zadejte v sekundách)")
    s2 = Console.WriteLine(Zadejte délku trasy pro druhé auto. (Zadejte v m/s)")
    t2 = Console.WriteLine(Zadejte čas, za kterou druhé auto ujelo trasu. (Zadejte v sekundách)")
    prumer1 = s1 / t1
    prumer2 = s2 / t2


    if(prumer1 > prumer2 = True) {
        Console.WriteLine("První auto je rychlejší o" + prumer1 - prumer2) + " m/s.")
    } else {if(prumer2 > prumer1 = True) {
        Console.WriteLine("Druhé auto je rychlejší o" + prumer2 - prumer1) + " m/s.")
    } else {if(prumer1 = prumer2) {
        Console.WriteLine("Obě auta jednou stejně")
    } else {
        Console.WriteLine("Nedokážu to spočítat")
    }





//Řešení:
//b06: První auto ujelo trasu s1 za čas t1 a druhé trasu s2 za čas t2. (údaje zadejte).
//Spočítejte průměrnou rychlost obou aut a vypište zprávu "... auto je o ... rychlejší".
//
//
//  s1 float, t1 float, s2 float, t2 float, r1 float, r2 float
//
//  s1 = Console.WriteLine(Zadej delku trasy prvniho auta [km]:")
//  t1 = Console.WriteLine(Zadej cas jizdy prvniho auta [h]:")
//  s2 = Console.WriteLine(Zadej delku trasy druheho auta [km]:")
//  t2 = Console.WriteLine(Zadej cas jizdy druheho auta [h]:")
//  r1 = s1 / t1
//  r2 = s2 / t2
//  if r1 > r2 {
//    Console.WriteLine("Prvni auto je o " + Round((r1 - r2), 2)) + " km/h rychlejsi"
//  } else {if r1 = r2 {
//    Console.WriteLine("Obe auta jedou stejnou rychlosti " + Round(r1, 2)) + " km/h"
//  } else {
//    Console.WriteLine("Druhe auto je o " + Round((r2 - r1), 2)) + " km/h rychlejsi"
//  }
//


    }
}
