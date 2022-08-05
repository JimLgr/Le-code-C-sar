// See https://aka.ms/new-console-template for more information
// string[] alphabet = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
using ConsoleAppCesar;
using System.Text;

Console.WriteLine("Tapez la chaine à chiffrer");
string chaineAChiffrer = Console.ReadLine().ToLower();

Console.WriteLine("Quel est le décalage désiré ?");
int decalage; 
Boolean resultTry  = Int32.TryParse(Console.ReadLine(), out decalage);
if (!resultTry)
{
    Console.WriteLine("taper un nombre correct");
    Console.Read();
    return;
}

// le decalage est positif et compris entre 0 et 25

string result = Cesar.Chiffrer(chaineAChiffrer, decalage);
Console.WriteLine(result.ToString());
Console.Write("\n");

Console.ReadKey();

// programmer la creation du tableau et puis le remplissage
// et puis l'affichage du contenu du tableau 



// decalage positif de 1  A => B ,    E => F
// decalage négatif de -1 B => A ,    E => D
// decalage positif de 25 B => A ,    E => D

// traitement sur decalage
// Si decalage est positif rien faire
// Si decalage est negatif decalage = decalage + 26 exemple -1 devient +25

// Si decalage est -261 => -261 modulo 26 => -1