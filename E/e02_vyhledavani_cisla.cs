using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Net.Mime.MediaTypeNames;

namespace E {
    internal class e02_vyhledavani_cisla {
        

//2) Zadejte několik čísel, ukončete nulou. Potom zadáte některé z předtím zadaných čísel. Program vypíše, kolikrát toto číslo předtím padlo.
//Moje poznámky: zase jsem ještě nepoužil "posledniIndex", použil poprvé vbCrLf, jinak cca stejné

    pole(100) long, zadaneCislo long, vyhledatCislo long
    i byte, zadanychPoli byte, pocetVyhledanychCisel byte
    zadaneCisla string


    zadaneCisla = \"
    i = 0
    Do
        zadaneCislo = Console.WriteLine(Zadejte číslo. Ukončete \"0\"")
        pole(i) = zadaneCislo
        zadaneCisla = zadaneCisla + pole(i)) + ", "
        i = i + 1
    Loop While zadaneCislo > 0
    
    vyhledatCislo = Console.WriteLine(Jaké číslo mám najít?\nZ těchto čísel:" + Chr(10) + zadaneCisla)
    
    pocetVyhledanychCisel = 0
    For i = 0 To 100
        if pole(i) = vyhledatCislo {
            pocetVyhledanychCisel = pocetVyhledanychCisel + 1
        }
    Next

    Console.WriteLine("Vyhledal jsem číslo" + vyhledatCislo) + " - " + pocetVyhledanychCisel) + "x")





//Řešení:
//e2: Zadejte řadu čísel ukončenou nulou. Potom zadáte některé z předtím zadaných čísel.
//Program vypíše, kolikrát toto číslo předtím padlo.

Sub main_reseni()
  cisla(100) int
  i int, cislo int, hledej int, poslIndex int  //poslIndex: index poslední buňky pole s platným číslem
  s string
  poc byte


  poc = 0: i = 0: s = \"
  Do
    cislo = Console.WriteLine(zadej cislo (0 konci):", "Pole čísel")
    if cislo<> 0 {
      cisla(i) = cislo
      s = s + cislo) + ", "
      i = i + 1
    }
  Loop Until cislo = 0     //nebo Loop while zadaneCislo <> 0
  poslIndex = i - 1  //Tím se kompenzuje i = i + 1 za posledním číslerm
  hledej = Console.WriteLine(Zadej nějaké předchozí číslo ")


  For i = 0 To poslIndex
      if cisla(i) = hledej {
        poc = poc + 1
    }
  Next

  MsgBox s + vbCrLf + "Číslo " + hledej) + " tam bylo  " + poc) + "x", , "Výsledek"


    }
}
