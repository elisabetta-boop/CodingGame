// QUE VAIS-JE APPRENDRE ?
// Résoudre ce puzzle vous fait comprendre le concept de boucle et comment trouver le maximum d'une liste d'entiers.
// Ce puzzle est aussi un terrain de jeu pour tester le concept de tri en utilisant jusqu'à 25 langages de programmation. Enfin il vous fait découvrir la programmation fonctionnelle.
// OPPORTUNITÉS D'APPRENTISSAGE
// Les concepts suivants peuvent vous aider à résoudre ce puzzle. Découvrez-les et mettez-les en pratique pour continuer votre progression.
// Boucles
// ÉNONCÉ
// Un problème simple pour expérimenter la plateforme CodinGame : votre programme doit trouver la montagne la plus haute parmi une liste de montagnes.
// HISTOIRE
// Le vaisseau Destiny est en danger : attiré vers le bas, il risque de s'écraser contre les montagnes d'une planète inconnue. Aidez Rick à détruire les montagnes... sauvez le Destiny !

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Player
{
    static void Main(string[] args)
    {
        int index_max_high_montain = 0;
        int high_max_montain = -1;
        // game loop
        while (true)
        {
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine());
                if (i==0)
                {
                    index_max_high_montain = i;
                    high_max_montain = mountainH;
                }
                else if(high_max_montain < mountainH )
                {
                    index_max_high_montain = i;
                    high_max_montain = mountainH;
                }
            }


            Console.WriteLine(index_max_high_montain); 
        }
    }
}