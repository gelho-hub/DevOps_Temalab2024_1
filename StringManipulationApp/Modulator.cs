using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationApp
{
    public class Modulator
    {
        public Modulator() { }
        public string FirstStringModulator(string GotText) // minden magánhangzó után v + a magánhangzó
        {
            List<string> maganhangzok = new List<string>() { "a", "á", "e", "é", "i", "í", "o", "ó", "ö", "ő", "u", "ú", "ü", "ű"};

            string newString = "";
            for (int i = 0; i < GotText.Length; i++)
            {
                newString += GotText[i];
                for (int j = 0;j < maganhangzok.Count; j++)
                {
                    if (GotText[i].ToString().ToLower() == (maganhangzok[j]))
                    {
                        newString += "v" + GotText[i];
                        break;
                    }
                }
            }
            return newString;
        }
        public string Squeeze(string text, string removableText)
        {
            string newString = text;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < removableText.Length; j++)
                {
                    if (text[i] == removableText[j])
                    {
                        newString = newString.Replace(removableText[j].ToString(), "");
                    }
                    
                }
            }
            return newString;
            // Írj olyan "squeeze" programot, amely egy sztringből az összes olyan karaktert törli,
            // amelyik szerepel egy második sztringben! Például "megadott sztring", "gt" esetén: "meado szrin" az eredmény.
        }
    }
}
