using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace E {

    internal class e15_morseovka {

        public static void Mainx() {
            //15) Uživatel zadá několik slov(bez diakritiky).
            //Program zapíše tento text v Morseově abecedě.
            //Oddělovačem znaků bude lomítko.
            //zadat všechna slova do jednoho inputboxu, oddělená normálně mezerami.
            //A mezera se překládá taky jako lomítko.
            //Tedy na hranicích slov budou vlastně dvě lomítka.-(Nutná znalost Morseovy abecedy).
            // A: .–      N: –.
            // B: –...    O: –––
            // C: –.–.    P: .––.
            // D: –..     Q: ––.–
            // E: .       R: .–.
            // F: ..–.    S: ...
            // G: ––.     T: –
            // H: ....    U: ..–
            // I: ..      V: ...–
            // J: .–––    W: .––
            // K: –.–     X: –..–
            // L: .–..    Y: –.––
            // M: ––      Z: ––..

            Console.WriteLine("Zadejte slova (bez diakritiky) a já ti je převedu do Morseovky. Odděl slova mezerami.");
            string zadaneSlova = Console.ReadLine();
            zadaneSlova = zadaneSlova.ToUpper();
            char[] pole = new char[zadaneSlova.Length];
            string vypisMorseovky = "";

            for (int i = 0; i < zadaneSlova.Length; i++) {
                pole[i] = char.Parse(zadaneSlova.Substring(i, 1));
                switch (pole[i]) {
                    case 'A': vypisMorseovky += ".–"; break;
                    case 'B': vypisMorseovky += "–..."; break;
                    case 'C': vypisMorseovky += "–.–."; break;
                    case 'D': vypisMorseovky += "–.."; break;
                    case 'E': vypisMorseovky += "."; break;
                    case 'F': vypisMorseovky += "..–."; break;
                    case 'G': vypisMorseovky += "––."; break;
                    case 'H': vypisMorseovky += "...."; break;
                    case 'I': vypisMorseovky += ".."; break;
                    case 'J': vypisMorseovky += ".–––"; break;
                    case 'K': vypisMorseovky += "–.–"; break;
                    case 'L': vypisMorseovky += ".–.."; break;
                    case 'M': vypisMorseovky += "––"; break;
                    case 'N': vypisMorseovky += "–."; break;
                    case 'O': vypisMorseovky += "–––"; break;
                    case 'P': vypisMorseovky += ".––."; break;
                    case 'Q': vypisMorseovky += "––.–"; break;
                    case 'R': vypisMorseovky += ".–."; break;
                    case 'S': vypisMorseovky += "..."; break;
                    case 'T': vypisMorseovky += "–"; break;
                    case 'U': vypisMorseovky += "..–"; break;
                    case 'V': vypisMorseovky += "...–"; break;
                    case 'W': vypisMorseovky += ".––"; break;
                    case 'X': vypisMorseovky += "–..–"; break;
                    case 'Y': vypisMorseovky += "–.––"; break;
                    case 'Z': vypisMorseovky += "––.."; break;
                    case ' ': vypisMorseovky += ""; break;
                    default:
                        vypisMorseovky += "neznámý znak";
                        break;
                }
                vypisMorseovky += "/";
            }
            Console.WriteLine(vypisMorseovky);
        }

        //public static void Mainx_b() {
        //    //15b) Zdokonalení programu:
        //    //text bude v souboru, Morseovka se zapíše do jiného souboru.
        //    //Další program bude naopak načíst Morseovku a převádět na běžný text.
        //    //(Práce se soubory -pokročilejší látka, bere se až v prezenčním kurzu.Tedy v přípravném kurzu nevypracovávat.)

        //}
    }
}