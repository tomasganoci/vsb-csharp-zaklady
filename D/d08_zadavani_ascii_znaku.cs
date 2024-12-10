using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {
    internal class d08_zadavani_ascii_znaku {
        

//8) Varianta příkladu ze skupiny b: Uživatel opakovaně zadá znak, program vždy odpoví, zda se jedná o písmeno, číslici nebo jiný znak.
//Zadávání končí zadáním např. nuly (nebo to pro změnu zkuste ukončit nějakým jiným znakem).
//Řešte pomocí } else { if.
//Moje poznámky: skoro stejný postup

    zadanyZnak string, zadaneZnaky string


    zadaneZnaky = \"
    Do
    zadanyZnak = Console.WriteLine(Zadejte znak a já ti napíšu o jaký typ znaku se jedná.\nUkončete znakem \";\"")
    zadaneZnaky = zadaneZnaky + zadanyZnak + Chr(10)
    if zadanyZnak<> ";" {
        if (zadanyZnak >= "a"  && zadanyZnak <= "z") {
          Console.WriteLine("Znak je malé písmeno"
        } else {if(zadanyZnak >= "A"  && zadanyZnak <= "Z") {
          Console.WriteLine("Znak je velké písmeno"
        } else {if(zadanyZnak >= "0"  && zadanyZnak <= "9") {
          Console.WriteLine("Znak je číslo"
        } else {
          Console.WriteLine("Znak je jiný znak"
        }
    }
    Loop Until zadanyZnak = ";"
    Console.WriteLine("Zadané znaky:" + Chr(10) + zadaneZnaky)


//Řešení:

//d08: Varianta příkladu ze skupiny b: Uživatel opakovaně zadá znak, program vždy odpoví, zda se jedná o písmeno,
//číslici nebo jiný znak. Zadávání končí zadáním prázdného znaku (tedy jen ENTER). Řešte pomocí } else { if.

Sub main_reseni()
znak string  //ve Visual studiu by se použil typ Char

Do
  znak = Console.WriteLine(Zadej znak:", "Druh znaku [číslo,písmeno,jiný]")
  if znak<> \" {
    ifc(znak) >= 97  &&c(znak) <= 122 {   //druhá možnost
    //if znak >= "a"  && znak <= "z" {
      Console.WriteLine("znak je malé písmeno", , "vysledek"
    } else {if znak >= "A"  && znak <= "Z" {
      Console.WriteLine("znak je velké písmeno", , "vysledek"
    } else {if znak >= "0"  && znak <= "9" {
      Console.WriteLine("znak je číslo", , "vysledek"
    } else {
      Console.WriteLine("znak není písmeno ani číslo", , "vysledek"
    }
  }
Loop Until znak = \"


//d08: Varianta příkladu ze skupiny b: Uživatel opakovaně zadá znak, program vždy odpoví, zda se jedná o písmeno,
//číslici nebo jiný znak. Zadávání končí zadáním prázdného znaku (tedy jen ENTER). Řešte pomocí } else { if.

Sub main_reseni_b()  //Tato verze je přehlednější, neboť v ní není vnořená podmínka
znak string, s string  //ve Visual studiu by se použil typ Char

Do
  znak = Console.WriteLine(Zadej znak:", "Druh znaku [číslo,písmeno,jiný]")


  if znak >= "a"  && znak <= "z" {
      s = "znak je malé písmeno"
  } else {if znak >= "A"  && znak <= "Z" {
      s = "znak je velké písmeno"
  } else {if znak >= "0"  && znak <= "9" {
      s = "znak je číslo"
  } else {
      s = "znak není písmeno ani číslo"
  }


  if znak <> \" { MsgBox s, , "výsledek"
Loop Until znak = \"



    }
}
