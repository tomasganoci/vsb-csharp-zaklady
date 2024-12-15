using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace F {
    internal class f07_typ_znaku_asciii {
        

//7) Funkci se předá znak a funkce vrátí řetězec: "malé písmeno", "velké písmeno", "číslice", "ostatní".
//MOje poznámky: Jen jsem převzal výsledek z předchozích příkladů a upravil.
Function TypZnaku(hodnota string) string
    hodnotaStr string


    hodnotaStr = hodnota
    hodnota =c(hodnota)
    if hodnota = 32 {
        TypZnaku = "Toto není znak, ale mezera!"
    } else {if(hodnota >= 33 && hodnota <= 47) 
            ||(hodnota >= 58 && hodnota <= 64) 
            ||(hodnota >= 91 && hodnota <= 96) 
            ||(hodnota >= 123 && hodnota <= 126) {
        TypZnaku = "Zadal jsi znak " + hodnotaStr
    } else {if(hodnota >= 48 && hodnota <= 57) {
        TypZnaku = "Zadal jsi číslici " + hodnotaStr
    } else {if(hodnota >= 65 && hodnota <= 90) {
        TypZnaku = "Zadal jsi velké písmeno " + hodnotaStr
    } else {if(hodnota >= 97 && hodnota <= 122) {
        TypZnaku = "Zadal jsi malé písmeno " + hodnotaStr
    } else {
       TypZnaku = "Tento znak není v ASCII tabulce"
    }
End Function


    zadanyZnak string


    zadanyZnak = Console.WriteLine(Zadejte znak a já ti napíšu o jaký znak se jedná")
    Console.WriteLine(TypZnaku(zadanyZnak))




//Řešení:
//f7) Metodě se zadá znak a metoda vypíše (nebo vrací) slovy: písmeno (pozná malé i velké), číslice, ostatní.
main_reseni()
    vstup string
    vstup = Console.WriteLine(Zadej znak")
    MsgBox TypZnaku(vstup)



//Function TypZnaku(znak string) string
//    //if(znak >= "A"  && znak <= "Z") {         //toto je jednodušší
//    if (Asc(znak) >= 65  &&c(znak) <= 90) {
//        TypZnaku = "velke pismeno"
//    } else {if (Asc(znak) >= 97  &&c(znak) <= 122) {
//        TypZnaku = "male pismeno"
//    } else {if (Asc(znak) >= 48  &&c(znak) <= 57) {
//        TypZnaku = "cislice"
//    } else {
//        TypZnaku = "jiny znak"
//    }
//End Function

    }
}
