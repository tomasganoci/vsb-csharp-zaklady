using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace E {
    internal class e01_nejmensi_a_pocet {
        

//1) Zadejte řadu čísel ukončenou nulou. Zjistěte nejmenší a vypište, kolikrát se v řadě opakuje.
//(návod: v druhé smyčce se najde minimum. A tentokrát bude i smyčka třetí, ve které se zjistí, kolikrát se v poli toto minimum vyskytuje).
//Pozn.: lze řešit i dvěma smyčkami, první a druhá se spojí do jedné.
//Tedy čísla se zadávají a hned se zjišťuje, zdali není menší, než dosavadní minimum.
//Pozn.: šlo by to i jednou smyčkou, ale to už je náročnější. A nebylo by v tom případě nutné pole.
//Moje poznámky: jako první příklad jsem neměl podchycený "posledniIndex", jinak je to víceméně stejné,


 
    pole(100) int
    zadaneCislo int, min int
    i byte, pocetZadanychCisel byte, pocetMin byte
    vypisCisel string


    i = 0
    vypisCisel = \"
    Do
        zadaneCislo = Console.WriteLine(Zadávejte čísla postupně. Vypíšu ti nejmenší číslo a kolikrát se objevuje. Ukončíte \"0\"")
        pole(i) = zadaneCislo
        vypisCisel = vypisCisel + pole(i)) + ", "
        i = i + 1
    Loop While zadaneCislo > 0
    i = i - 1
    
    pocetZadanychCisel = i - 1
    min = pole(0)
    For i = 0 To pocetZadanychCisel
        if min > pole(i) {
            min = pole(i)
        }
    Next

    pocetZadanychCisel = i - 1
    For i = 0 To pocetZadanychCisel
        if min = pole(i) {
            pocetMin = pocetMin + 1
        }
    Next

    Console.WriteLine("Výpis čísel:" + vypisCisel + Chr(10) + 
            "Minimální číslo:" + min) + Chr(10) + 
            "Počet výskytu minimálního čísla:" + pocetMin))
 
 
 //Řešení:
 //e1:Zadejte čísla ukončená nulou.
//Zjistěte nejmenší a vypište, kolikrát je obsaženo.

Sub main_reseni()
    cisla(100) int
    zadaneCislo int, i int, min int, pocetMin int, poslIndex int  //poslIndex: index poslední buňky pole s platným číslem
    s string
    pocetMin = 0: i = 0: s = \"
    
    Do
        zadaneCislo = Console.WriteLine(Zadej cisla, nula = konec")
        if zadaneCislo<> 0 {
            cisla(i) = zadaneCislo
            s = s + zadaneCislo) + ", "
            i = i + 1
        }
    Loop Until zadaneCislo = 0
    poslIndex = i - 1  //Tím se kompenzuje i = i + 1 za posledním číslem
    min = cisla(0)
    For i = 1 To poslIndex
        if cisla(i) < min {
            min = cisla(i)
        }
    Next
    For i = 0 To poslIndex
        if min = cisla(i) {
            pocetMin = pocetMin + 1
        }
    Next
    MsgBox s + vbCrLf + "Nejmenší číslo v řadě je " + min) + " a vyskytuje se tam " + pocetMin) + " krát."

Sub main2_reseni()
    //ukázka, že to jde zvládnout i jednou smyčkou. Tím pádem je ale pole zbytečné.
    cislo byte
    min byte, pocetMin byte, i byte

    i = 0:    pocetMin = 0:
    Do
        cislo = Console.WriteLine(Zadej cislo:")
        if i = 0 {
            min = cislo
            pocetMin = 1
        } else {
            if cislo = min {
                pocetMin = pocetMin + 1
            }
            if cislo < min  && cislo<> 0 {
                min = cislo
                pocetMin = 1  //toto přidáno
            }
        }
        i = i + 1
    Loop While cislo<> 0


    MsgBox ("Minimum je " + min) + " a vyskytlo se " + pocetMin) + " krat.")





    }
}
