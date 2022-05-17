// QUE VAIS-JE APPRENDRE ?
// Résoudre ce puzzle vous apprend à gérer les chaînes de caractères et les calculs dans un tableau.

// Il vous faut couper des chaînes de caractères en plusieurs morceaux et les concaténer en d'autres. Vous pouvez aussi utiliser les index de tableau

// Ressources externes Chaînes de caractères(EN) Let's Play ASCII Art📖 Boucles
// OPPORTUNITÉS D'APPRENTISSAGE
// Les concepts suivants peuvent vous aider à résoudre ce puzzle. Découvrez-les et mettez-les en pratique pour continuer votre progression.

// Chaînes de caractères
// Tableaux
// Boucles
// ÉNONCÉ
// Votre programme doit afficher une ligne de texte en art ASCII.

// Vous devez séparer des chaînes de caractères, les enregistrer et en recréer d'autres. Vous pouvez utiliser une structure de donnée (comme un tableau) ou une structure de donnée associative (comme une table de hachage ou dictionnaire).

// RÉSOUDRE
// HISTOIRE
// Vous-vous sentez l'âme d'un artiste ? Mais vous êtes informaticien :( Alors pourquoi ne pas essayer l'...

//    __    ___   ___  ____  ____      __    ____  ____ 
//   /__\  / __) / __)(_  _)(_  _)    /__\  (  _ \(_  _)
//  /(__)\ \__ \( (__  _)(_  _)(_    /(__)\  )   /  )(  
// (__)(__)(___/ \___)(____)(____)  (__)(__)(_)\_) (__) 
 
// Dans ce défi, transformez des chaînes de caractères en ASCII ART.

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Solution
{
    static void Main(string[] args)
    {
     int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine();

        const int A = (int) 'A';
        const int Z = (int) 'Z';

        string str = T.ToUpper();

        for (int i = 0; i < H; i++) {

            string row = Console.ReadLine();
            string ret = "";

            foreach (var s in str) {
                var c = (int) s;

                if (c < A || c > Z)
                    ret+= row.Substring(L * (Z - A + 1), L);
                else
                    ret+= row.Substring(L * (c - A), L);
            }
            Console.WriteLine(ret);
    }
}}