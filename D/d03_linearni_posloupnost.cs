using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {
    internal class d03_linearni_posloupnost {
        

//3) Zadejte první, druhy a poslední člen lineární celočíselné posloupnosti (lineární posloupnost je taková, kde mezi jednotlivými členy jsou stejné odstupy, např. 12, 15, 18, 21...).
//Program zobrazí pod sebou všechny prvky posloupnosti.
//Pozn.: program musí fungovat, i kdyby třetí zadané číslo se nestrefilo do členů posloupnosti (tedy kdyby toto číslo nebylo v posloupnosti obsaženo).
//Takže je to třeba chápat spíše tak, že třetí zadané číslo je limit.
//Varianta: Zadá se první a druhy krok a počet prvku posloupnosti.
//Moje poznámky: trochu jinak jsem pochopil zadání, myslel jsem že druhé číslo značí lineární posloupnost.


    prvniCislo int, druheCislo int, posledniCislo int, linearniPosloupnost int
    posloupnoststring string


    prvniCislo = Console.WriteLine(Zadejte první číslo lineární posloupnosti")
    druheCislo = Console.WriteLine(Zadejte druhé číslo lineární posloupnosti")
    posledniCislo = Console.WriteLine(Zadejte poslední číslo lineární posloupnosti")


    posloupnoststring = "Číslo:" + prvniCislo) + " posloupnost:" + druheCislo) + Chr(10)
    linearniPosloupnost = prvniCislo + druheCislo
    Do Until linearniPosloupnost > posledniCislo
        posloupnoststring = posloupnoststring + "Číslo:" + linearniPosloupnost) + Chr(10)
        linearniPosloupnost = linearniPosloupnost + druheCislo
    Loop
    Console.WriteLine(posloupnoststring)


//Řešení:

//d03: Zadejte první, druhy a poslední člen lineární celočíselné posloupnosti.
//Program vytiskne pod sebou všechny prvky posloupnosti.

main_reseni()
  prvni int, druhy int, posledni int, rozdil int, dalsiCislo int
  s string


  prvni = Console.WriteLine(Zadej 1 cislo posloupnosti")
  druhy = Console.WriteLine(Zadej 2 cislo posloupnosti")
  posledni = Console.WriteLine(Zadej posledni cislo posloupnosti")
  rozdil = druhy - prvni
  dalsiCislo = druhy
  s = prvni) + Chr(10) + druhy) + Chr(10)


  Do While(dalsiCislo + rozdil) <= posledni    //toto by se dalo řešit i pomocí for, neboť se počet průchodů smyčkou dá předem spočítat
    dalsiCislo = dalsiCislo + rozdil
    s = s + dalsiCislo) + Chr(10)
  Loop
  if(dalsiCislo<> posledni) { s = "Koncové číslo " + posledni) + " neni součástí linearni posloupnosti" + Chr(10) + s
  MsgBox s, , "Lineární řada čísel " + prvni) + ", " + druhy) + " .. " + posledni)


//d03b: Zadejte první, druhy a poslední člen lineární posloupnosti.
//Program vytiskne pod sebou všechny prvky posloupnosti.
//Varianta b: Zadá se první a druhy krok a počet prvku posloupnosti.

main_reseni_b()
  prvni int, druhy int, pocetCisel int, rozdil int, dalsiCislo int, i int
  s string


  i = 2
  prvni = Console.WriteLine(Zadej 1 cislo posloupnosti")
  druhy = Console.WriteLine(Zadej 2 cislo posloupnosti")
  pocetCisel = Console.WriteLine(Zadej pocet cisel posloupnosti")
  rozdil = druhy - prvni
  dalsiCislo = druhy
  s = prvni) + Chr(10) + druhy) + Chr(10)


  Do                                    //toto by bylo vhodnější řešit pomocí for, neboť je počet průchodů smyčkou znám
    dalsiCislo = dalsiCislo + rozdil
    s = s + dalsiCislo) + Chr(10)
    i = i + 1
  Loop While i<pocetCisel


  Console.WriteLine("Lineární řada pro " + pocetCisel) + " cisel začínajících na " + prvni) + ", " + druhy) + " je: " + Chr(10) + s



    }
}
