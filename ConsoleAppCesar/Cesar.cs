using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCesar
{
    public class Cesar
    {
        const int CODE_ASCII_A_MINUSCULE = 97;
        const int LONGUEUR_ALPHABET = 26;
        static readonly char[] alphabet;
        static int limiteSuperieure = CODE_ASCII_A_MINUSCULE + LONGUEUR_ALPHABET;

        // Ceci est un constructeur de classe
        static Cesar()
        {
            alphabet = new char[LONGUEUR_ALPHABET];
            for (int lettre = CODE_ASCII_A_MINUSCULE, cpt = 0; lettre < limiteSuperieure; lettre++, cpt++)
            {
                alphabet[cpt] = (char)lettre;
            }
        }

        public static string Chiffrer(string pTexteAChiffrer, int pDecalage)
        {
            string texteAChiffrer = pTexteAChiffrer.ToLower();

            // Traitement décalage
            int decalage = pDecalage;
            decalage = decalage % LONGUEUR_ALPHABET;
            if (decalage < 0)
            {
                decalage += LONGUEUR_ALPHABET;
            }
            StringBuilder result = new StringBuilder();
            foreach (char ch in texteAChiffrer)
            {
                int index = Array.IndexOf(alphabet, ch, 0);

                if (index >= 0)
                {
                    char cryptedChar = alphabet[(index + decalage) % LONGUEUR_ALPHABET];
                    result.Append(cryptedChar);
                }
                else
                {
                    result.Append(ch);
                }
            }
            return result.ToString();
        }
    }
}
