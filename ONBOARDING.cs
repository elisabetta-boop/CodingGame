// QUE VAIS-JE APPRENDRE ?
// Résoudre ce puzzle vous aide à comprendre le fonctionnement des puzzles sur CodinGame (récupération des données d’entrée, boucle de jeu, envoi des résultats sur la sortie standard).
// Vous pouvez découvrir la plate-forme avec cet exercice simple de comparaison de valeurs et découvrir plus de 25 langages de programmation.
// DÉCOUVREZ DES ASTUCES DE SYNTAXE ASSOCIÉES À CE PUZZLE
// [EN] Ternary Operator par Nick
// Ressources externes ConditionsFlux standards
// OPPORTUNITÉS D'APPRENTISSAGE
// Les concepts suivants peuvent vous aider à résoudre ce puzzle. Découvrez-les et mettez-les en pratique pour continuer votre progression.
// Conditions
// ÉNONCÉ
// Une mission tutoriel pour les nouveaux venus : votre programme doit trouver laquelle des deux cibles est la plus proche.
// HISTOIRE
// Défendez la planète des attaques de vaisseaux extra-terrestres, armé d'un canon-laser automatisé.

using System;

class Player
{
    static void Main(string[] args)
    {

        // game loop
        while (true)
        {
            string enemy1 = Console.ReadLine(); // name of enemy 1
            int dist1 = int.Parse(Console.ReadLine()); // distance to enemy 1
            string enemy2 = Console.ReadLine(); // name of enemy 2
            int dist2 = int.Parse(Console.ReadLine()); // distance to enemy 2

            // Write an action using Console.WriteLine()
            
            if (dist1 < dist2) {
                Console.WriteLine(enemy1);
            } else {
                Console.WriteLine(enemy2);
            }
            // Enter the code here

        }
    }
}