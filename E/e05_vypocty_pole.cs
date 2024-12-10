using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace E {
    internal class e05_vypocty_pole {
        

//5) Zadejte v jednom cyklu řadu čísel.
//V dalších cyklech program poté spočítá jejich součet, průměr, maximum, minimum.
//Pak se program ještě zeptá, zda chcete zobrazit součet druhých mocnin.
//Moje poznámky: chtěl jsem při zadání řešit "zadanéČíslo" randomem, abych to nemusel vypisovat,
//vkládat poslední index,


    Const pole = 99


    zadanaCisla byte, i byte, cislaPole(pole) byte, pocetCisel byte, minCislo byte, maxCislo byte
    soucetCisel int
    prumerCisel float
    odpovedMocnina string
    soucetMocnin long


    Randomize
    For i = 0 To pole
        zadanaCisla = Int(Rnd()* (100 - 1 + 1) + 1)
        cislaPole(i) = zadanaCisla
        pocetCisel = pocetCisel + 1
    Next

    minCislo = cislaPole(0)
    maxCislo = cislaPole(0)


    For i = 0 To pole
        soucetCisel = soucetCisel + cislaPole(i)
        soucetMocnin = soucetMocnin + cislaPole(i) ^ 2
        if cislaPole(i) < minCislo {
            minCislo = cislaPole(i)
        } else {if cislaPole(i) > maxCislo {
            maxCislo = cislaPole(i)
        }
    Next

    prumerCisel = soucetCisel / pocetCisel


    Console.WriteLine("Součet:" + soucetCisel) + Chr(10) + 
            "Průměr:" + prumerCisel) + Chr(10) + 
            "Min:" + minCislo) + Chr(10) + 
            "Max:" + maxCislo) + Chr(10))
    
    odpovedMocnina = Console.WriteLine(Chcete zobrazit součet druhých mocnin? (A/N)")
    if odpovedMocnina = "A" {
        Console.WriteLine("Součet druhých mocnin:" + soucetMocnin))
    } else {
        Console.WriteLine("Ok, pro dnešek končím")
    }


//Řešení:
//e5: Zadejte v jednom cyklu řadu čísel. V dalším cyklu program poté spočítá jejich součet, průměr, maximum, minimum.
//Pak se program ještě zeptá, zda chcete zobrazit součet druhých mocnin.
Sub main_reseni()
    cisla(100) int
    zadaneCislo int, soucet int, max int, min int, pocetNe0 int, soucetMocnin int, i int, poslIndex int  //poslIndex: index poslední buňky pole s platným číslem
    s string, volba string
    soucet = 0:  soucetMocnin = 0: i = 0: s = \"
    
    Do
        zadaneCislo = Console.WriteLine(Zadej zadaneCislo, zadavani ukoncis cislem 0")
        if zadaneCislo<> 0 {
            s = s + Chr(10) + zadaneCislo)
            cisla(i) = zadaneCislo
            i = i + 1
        }
    Loop Until zadaneCislo = 0
    poslIndex = i - 1   //Tím se kompenzuje i = i + 1 za posledním číslerm
    max = cisla(0)
    min = cisla(0)


    For i = 0 To poslIndex
        soucet = soucet + cisla(i)


        if cisla(i) > max {
            max = cisla(i)
        }


        if cisla(i) < min {
            min = cisla(i)
        }


        soucetMocnin = soucetMocnin + cisla(i) ^ 2
    Next

    s = s + Chr(10) + "Součet:" + " " + soucet) + Chr(10) + "Maximum:" + " " + max) + Chr(10) + "Minimum:" + " " + min)


    volba = Console.WriteLine(Chcete zobrazit i součet druhých mocnin? (a/n)")
    if volba = "a" {
        MsgBox s + Chr(10) + "Součet 2. mocnin:" + " " + soucetMocnin)
    } else {
        MsgBox s
    }


    }
}
