using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace D {

    internal class d05_vypis_cisel {

        public static void Mainx() {
            //5) Zadejte několik celých čísel, ukončete nulou (ta již do dat nepatří).
            //Program v MsgBoxu vypíše daná čísla, jejich počet, součet, průměr, minimum, maximum.
            //Případně ještě vypíše ta z nich, která jsou sudá a jejich počet.
            //Případně ještě vypíše ta z nich, která jsou větší, než první číslo.
            //Nezapomeňte si ve skriptech přečíst kapitolu o inicializaci minima.
            //Moje poznámky: jsou to různé postupy,

            int zadaneCislo, pocetCisel, soucetCisel, pocetSudych;
            string sudeCisla, zadanaCisla, cislaVetsiNezPrvni;

            sudeCisla = "";
            zadanaCisla = "";
            cislaVetsiNezPrvni = "";
            pocetCisel = 0;
            soucetCisel = 0;
            zadaneCislo = 0;
            pocetSudych = 0;
            int i = 0;
            int cisloMax = 0;
            int cisloMin = 0;
            int vetsinezprvni = 0;

            do {
                Console.WriteLine("Zadejte číslo a já ti vypíšu vše co dokážu. (Ukončete \"0\")");
                zadaneCislo = int.Parse(Console.ReadLine());
                if (zadaneCislo != 0) {
                    zadanaCisla += $"{zadaneCislo}, ";
                    pocetCisel++;
                    soucetCisel += zadaneCislo;

                    if (zadaneCislo % 2 == 0) {
                        sudeCisla += $"{zadaneCislo},";
                        pocetSudych++;
                    }
                    if (i == 0) {
                        cisloMax = zadaneCislo; //in+;izializace čísla MAX
                        cisloMin = zadaneCislo; //inizializace čísla MIN
                        vetsinezprvni = zadaneCislo;
                    }
                    else {
                        if (cisloMax < zadaneCislo) {
                            cisloMax = zadaneCislo;
                        }
                        else {
                            if (cisloMin > zadaneCislo) {
                                cisloMin = zadaneCislo;
                            }
                        }
                        if (zadaneCislo > vetsinezprvni) {
                            cislaVetsiNezPrvni += $"{zadaneCislo},";
                        }
                    }
                }
                i = i + 1;
            }
            while (zadaneCislo != 0);

            Console.WriteLine($"Zadaná čísla: {zadanaCisla}\n" +
                    $"Počet čísel: {pocetCisel}\n" +
                    $"Součet čísel: {soucetCisel}\n" +
                    $"Průměr čísel: {Math.Round(Convert.ToDouble(soucetCisel) / Convert.ToDouble(pocetCisel), 2)}\n" +
                    $"Sudé čísla: {sudeCisla}\n" +
                    $"Počet sudých čísel: {pocetSudych}\n" +
                    $"Minimální číslo: {cisloMin}\n" +
                    $"Maximální číslo: {cisloMax}\n" +
                    $"První číslo: {vetsinezprvni}\n" +
                    $"Větší než první: {cislaVetsiNezPrvni}");
        }

        public static void Mainx_reseni() {
            //Řešení:

            //d05: Zadejte řadu celých čísel ukončenou nulou (která do řady již nepatří).
            //Program v MsgBoxu vypíše daná čísla, jejich počet, součet, průměr, maximum.
            //Případně ještě vypíše ta z nich, která jsou sudá a jejich počet.
            //Případně ještě vypíše ta z nich, která jsou větší, než první číslo.

            long cislo, max, prvni;
            string s, strSuda, vys;
            byte pocet, pocetSudych;
            double Prumer;

            vys = "";
            strSuda = "";
            pocetSudych = 0;
            prvni = 0;
            max = 0;
            s = "";
            pocet = 0;
            double suma = 0;

            Console.WriteLine("Zadej celé číslo [0=konec]");
            cislo = long.Parse(Console.ReadLine());
            if (cislo != 0) {
                max = cislo;
                if (cislo % 2 == 0) {
                    strSuda += $"{cislo}, ";
                    pocetSudych++;
                }
                s = $"{cislo}, ";
                pocet = 1;
                suma = cislo;
                prvni = cislo;
            }

            while (cislo != 0) {
                Console.WriteLine("Zadej celé číslo [0=konec]");
                cislo = long.Parse(Console.ReadLine());
                if (cislo != 0) {
                    if (cislo > prvni) {
                        vys += $"{cislo}, ";
                        if (cislo > max) {
                            max = cislo;
                            if (cislo % 2 == 0) {
                                strSuda += $"{cislo}, ";
                                pocetSudych++;
                            }
                            s += $"{cislo}, ";
                            pocet++;
                            suma = suma + cislo;
                        }
                    }
                }
            }
            if (pocet != 0) {
                Prumer = Math.Round(suma / pocet, 2);
                Console.WriteLine($"Zadaná čísla: {s}\nPočet: {pocet}\nSoučet: {suma}\nPrůměr: {Prumer}\nMax: {max}\n{pocetSudych} sudých čísel: {strSuda}\nVetsi nez prvni jsou: {vys}");
            }
        }

        public static void Mainx_reseni_b() {
            //d05: Zadejte řadu celých čísel ukončenou nulou (která do řady již nepatří).
            //Program v MsgBoxu vypíše daná čísla, jejich počet, součet, průměr, maximum.
            //Případně ještě vypíše ta z nich, která jsou sudá a jejich počet.
            //Případně ještě vypíše ta z nich, která jsou větší, než první číslo.

            //tato varianta je elegantnější než předchozí, protože přesunem inputboxu na konec smyčky
            //se zmenšilo množství příkazů, které se mají provést před smyčkou.
            //Také se ušetřilo vyhodnocování podmínky if cislo != 0 ve smyčce, protože
            //nyní se už číslo rovné nule ani do smyčky nedostane.
            //Náročné na pochopení však může být to, že číslo se zadává při jednom
            //průchodu smyčkou ale zpracovává se až při dalším.
            long cislo, max, prvni;
            string s, strSuda, vys;
            byte pocet, pocetSudych;
            double Prumer;

            vys = "";
            strSuda = "";
            pocet = 0;
            double suma = 0;
            pocetSudych = 0;
            s = "";

            Console.WriteLine("Zadej celé číslo [0=konec]");
            cislo = long.Parse(Console.ReadLine());
            max = cislo;
            prvni = cislo;

            while (cislo != 0) {
                if (cislo > prvni) {
                    vys += $"{cislo}, ";
                }
                if (cislo > max) {
                    max = cislo;
                }
                if (cislo % 2 == 0) {
                    strSuda += $"{cislo}, ";
                    pocetSudych++;
                }

                s += $"{cislo}, ";
                pocet++;
                suma += cislo;
                Console.WriteLine("Zadej celé číslo [0=konec]");
                cislo = long.Parse(Console.ReadLine());
            }
            if (pocet != 0) {
                Prumer = Math.Round(suma / pocet, 2);
                Console.WriteLine($"Zadaná čísla: {s}\nPočet: {pocet}\nSoučet: {suma}\nPrůměr: {Prumer}\nMax: {max})\n{pocetSudych} sudých čísel:  {strSuda}\nVetsi nez {prvni} jsou: {vys}");
            }
        }
    }
}