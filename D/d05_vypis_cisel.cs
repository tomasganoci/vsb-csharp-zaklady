using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace D {
    internal class d05_vypis_cisel {
        

//5) Zadejte několik celých čísel, ukončete nulou (ta již do dat nepatří).
//Program v MsgBoxu vypíše daná čísla, jejich počet, součet, průměr, minimum, maximum.
//Případně ještě vypíše ta z nich, která jsou sudá a jejich počet.
//Případně ještě vypíše ta z nich, která jsou větší, než první číslo.
//Nezapomeňte si ve skriptech přečíst kapitolu o inicializaci minima.
//Moje poznámky: jsou to různé postupy,

    zadaneCislo int, pocetCisel int, soucetCisel int, pocetSudych int
    prumerCisel int, cisloMin int, cisloMax int, i int, vetsinezprvni int
    sudeCisla string, zadanaCisla string, cislaVetsiNezPrvni string


    sudeCisla = \"
    zadanaCisla = \"
    cislaVetsiNezPrvni = \"
    i = 0
    
    Do
    zadaneCislo = Console.WriteLine(Zadejte číslo a já ti vypíšu vše co dokážu. (Ukončete \"0\")")
    if(zadaneCislo<> 0) {
        zadanaCisla = zadanaCisla + zadaneCislo) + ","
        pocetCisel = pocetCisel + 1
        soucetCisel = soucetCisel + zadaneCislo
        if(zadaneCislo % 2 = 0) {
            sudeCisla = sudeCisla + zadaneCislo) + ","
            pocetSudych = pocetSudych + 1
        }
        if(i = 0) {
            cisloMax = zadaneCislo //inizializace čísla MAX
            cisloMin = zadaneCislo //inizializace čísla MIN
            vetsinezprvni = zadaneCislo
        } else {if cisloMax<zadaneCislo {
            cisloMax = zadaneCislo
        } else {if cisloMin > zadaneCislo {
            cisloMin = zadaneCislo
        }
        if zadaneCislo > vetsinezprvni {
            cislaVetsiNezPrvni = cislaVetsiNezPrvni + zadaneCislo) + ","
        }
        i = i + 1
    }
    Loop Until zadaneCislo = 0
    
    Console.WriteLine("Zadaná čísla:" + zadanaCisla + Chr(10) + 
            "Počet čísel:" + pocetCisel) + Chr(10) + 
            "Součet čísel:" + soucetCisel) + Chr(10) + 
            "Průměr čísel:" + Round(soucetCisel / pocetCisel, 2)) + Chr(10) + 
            "Sudé čísla:" + sudeCisla + Chr(10) + 
            "Počet sudých čísel:" + pocetSudych) + Chr(10) + 
            "Minimální číslo:" + cisloMin) + Chr(10) + 
            "Maximální číslo:" + cisloMax) + Chr(10) + 
            "První číslo:" + vetsinezprvni) + Chr(10) + 
            "Větší než první:" + cislaVetsiNezPrvni)


//Řešení:

//d05: Zadejte řadu celých čísel ukončenou nulou (která do řady již nepatří).
//Program v MsgBoxu vypíše daná čísla, jejich počet, součet, průměr, maximum.
//Případně ještě vypíše ta z nich, která jsou sudá a jejich počet.
//Případně ještě vypíše ta z nich, která jsou větší, než první číslo.

main_reseni()
  cislo long, suma long, max long, prvni long
  s string, strSuda string, vys string
  pocet byte, pocetSudych byte
  Prumer Double


  vys = \": strSuda = \":
  
  cislo = Console.WriteLine(Zadej celé číslo [0=konec]")
  if cislo<> 0 {
      max = cislo
      if (cislo % 2) = 0 {
        strSuda = strSuda + cislo) + ", "
        pocetSudych = pocetSudych + 1
      }
      s = cislo) + ", "
      pocet = 1
      suma = cislo
      prvni = cislo
  }


  Do While cislo<> 0
    cislo = Console.WriteLine(Zadej celé číslo [0=konec]")
    if cislo<> 0 {
      if cislo > prvni { vys = vys + cislo) + ", "
      if cislo > max { max = cislo
      if (cislo % 2) = 0 {
        strSuda = strSuda + cislo) + ", "
        pocetSudych = pocetSudych + 1
      }
      s = s + cislo) + ", "
      pocet = pocet + 1
      suma = suma + cislo
        }
        Loop

  if pocet<> 0 {
    Prumer = Round(suma / pocet, 2)
    Console.WriteLine("Zadaná čísla:  " + s + Chr(10) + "Počet: " + pocet) + Chr(10) + "Součet: " + suma) + Chr(10) + "Průměr: " + Prumer) + Chr(10) & "Max: " + max) + Chr(10) + pocetSudych) + " sudých čísel: " + strSuda + Chr(10) + "Vetsi nez " + prvni) + " jsou:  " + vys, , "Vysledek"
  }


//d05: Zadejte řadu celých čísel ukončenou nulou (která do řady již nepatří).
//Program v MsgBoxu vypíše daná čísla, jejich počet, součet, průměr, maximum.
//Případně ještě vypíše ta z nich, která jsou sudá a jejich počet.
//Případně ještě vypíše ta z nich, která jsou větší, než první číslo.

main_reseni_b()
  //tato varianta je elegantnější než předchozí, protože přesunem inputboxu na konec smyčky
  //se zmenšilo množství příkazů, které se mají provést před smyčkou.
  //Také se ušetřilo vyhodnocování podmínky if cislo <> 0 ve smyčce, protože
  //nyní se už číslo rovné nule ani do smyčky nedostane.
  //Náročné na pochopení však může být to, že číslo se zadává při jednom
  //průchodu smyčkou ale zpracovává se až při dalším.
  cislo long, suma long, max long, prvni long
  s string, strSuda string, vys string
  pocet byte, pocetSudych byte
  Prumer Double


  vys = \": strSuda = \":
  
  cislo = Console.WriteLine(Zadej celé číslo [0=konec]")
  max = cislo
  prvni = cislo


  Do While cislo<> 0
      if cislo > prvni { vys = vys + cislo) + ", "
      if cislo > max { max = cislo
      if(cislo % 2) = 0 {
        strSuda = strSuda + cislo) + ", "
        pocetSudych = pocetSudych + 1
      }
      s = s + cislo) + ", "
      pocet = pocet + 1
      suma = suma + cislo
      cislo = Console.WriteLine(Zadej celé číslo [0=konec]")
  Loop

  if pocet<> 0 {
      Prumer = Round(suma / pocet, 2)
      Console.WriteLine("Zadaná čísla:  " + s + Chr(10) + "Počet: " + pocet) + Chr(10) + "Součet: " + suma) + Chr(10) + "Průměr: " + Prumer) + Chr(10) & "Max: " + max) + Chr(10) + pocetSudych) + " sudých čísel: " + strSuda + Chr(10) + "Vetsi nez " + prvni) + " jsou:  " + vys, , "Vysledek"
  }



    }
}
