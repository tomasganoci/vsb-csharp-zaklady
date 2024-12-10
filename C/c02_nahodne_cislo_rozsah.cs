using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace C {
    internal class c02_nahodne_cislo_rozsah {
        

//2)  Program vygeneruje deset náhodných celých čísel (např. od -90 do 100). Zjistěte, kolik z nich je v určitém intervalu (např. od 10 do 50)
//S algoritmizací tohoto programu si někteří účastníci nevědí rady. Pokud je to i váš případ, tak příklad zkuste nejprve vyřešit bez počítače.
//Vezměte deset malých papírků na poznámky a napište na ně náhodně čísla od -90 do +100.
//Nachystejte si i papír, který nadepíšete např. pocetCiselVIntervalu.
//Potom vezměte první papírek, přečtěte jej,  a pokud je v rozsahu mezi 10 a 50, pak na papír nadepsaný pocetCiselVIntervalu napíšete čárku.
//Toto proveďte 10x (tedy na jiný papír, nazvaný index, si děláte čárky a až jich bude 10, tak skončíte).
//Poté slavnostně oznamte, kolik máte čárek na papíru pocetCiselVIntervalu. A pak to zkuste zapsat ve Visual Basicu.
//Vlastně stačí následující popis převést do angličtiny:
//Následující činnost proveď 10x (tedy zvyšuj při každém průchodu hodnotu proměnné index od 1 do 10):
//    načtěte do proměnné (papírku) náhodné číslo v rozsahu <-90, 100>
//    pokud je proměnná v rozsahu mezi 10 a 50, pak zvýšíte hodnotu proměnné pocetCiselVIntervalu o jedničku
//konec opakované činnosti
//oznamte hodnotu proměnné pocetCiselVIntervalu
//Moje poznámky: nedoplnil jsem, jaké čísla byli v rozsahu, vzal jsem to hodně stručně, doplnil jsem vygenerované čísla (vygenerovaneCisla) a jeké čísla byli v rozsahu (cislaVRozsahu)


    nahodneCislo float
    min int, max int
    i byte, pocetCiselVIntervalu byte
    vygenerovaneCisla string, cislaVRozsahu string


    min = -90
    max = 100
    
    pocetCiselVIntervalu = 0
    For i = 1 To 10
        nahodneCislo = Int(Rnd()* (max - min + 1) + min)
        vygenerovaneCisla = vygenerovaneCisla + nahodneCislo) + ", "
            if nahodneCislo >= 10  && nahodneCislo <= 50 {
                pocetCiselVIntervalu = pocetCiselVIntervalu + 1
                cislaVRozsahu = cislaVRozsahu + nahodneCislo) + ", "
            }
    Next
    Console.WriteLine("Rozmezí čísel: " + min) + " ->" + max) + Chr(10) + 
            "Vzorec: Int(Rnd() * (max - min + 1) + min)" + Chr(10) + 
            Chr(10) + 
            "Vygenerovaná čísla: " + vygenerovaneCisla + Chr(10) + 
            "Čísla v rozmezí 10-50: " + cislaVRozsahu + Chr(10) + 
            "Počet čísel v rozmezí 10-50: " + pocetCiselVIntervalu))
        
    


//Řešení:
//c02) Program vygeneruje deset celých čísel (např. od -90 do 100).
//Zjistěte, kolik z nich je v určitém intervalu (např. od 10 do 50)

Sub main_reseni()
  i int, rozsah int
  nah float
  s string, e string


  s = "                     cislo         v intervalu 10 az 50?"      // záhlaví
  rozsah = 100 - (-90) + 1
  For i = 1 To 10
    e = \"
    nah = Int(Rnd()* rozsah) - 90
    if((nah >= 10 && nah <= 50)) { e = "ano" // závorky by být použity nemusely, v jazycích rodiny C jsou ale povinno
    s = s + Chr(10) + i) + " cislo je        " + nah) + ("                ") + e
  Next


  MsgBox s



Sub main_reseni2()         // další varianta
  i byte, pocetVIntervalu byte, rozsah byte
  nah float
  s string
  vIntervalu string  // výstupní text čísla jen v intervalu


  pocetVIntervalu = 0
  s = "Padla tato náhodná čísla: "
  rozsah = 100 - (-90) + 1
  vIntervalu = "V intervalu od 10 do 50 byla tato čísla: "
  For i = 1 To 10
    nah = Int(Rnd()* rozsah) - 90
    if(nah >= 10 && nah <= 50) {
      vIntervalu = vIntervalu + nah) + ", "
      pocetVIntervalu = pocetVIntervalu + 1
    }
    s = s + nah) + ", "
  Next
  MsgBox s + Chr(10) + vIntervalu + Chr(10) + "Tedy v intervalu 10..50 bylo celkem " + pocetVIntervalu) + " čísel"
  



//Špatné řešení.
//
//    nahodneCislo string
//    max int, min int
//    i byte, pocetCiselVIntervalu byte
//
//    min = -90
//    max = 100
//    nahodneCislo = \"
//
//    For i = 1 To 20
//        nahodneCislo = nahodneCislo + "Index:" + i) + Chr(10) + "Náhodné číslo: " + Int(Rnd() * (max - min + 1) + min)) + Chr(10)
//    Next i
//    MsgBox ("Hodnoty min:" + min) + Chr(10) + "Hodnoty max:" + max) + Chr(10) + "Vzorec: Int(Rnd() * (max - min + 1) + min))" + Chr(10) + Chr(10) + nahodneCislo)
//

    }
}
