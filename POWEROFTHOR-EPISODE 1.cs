// QUE VAIS-JE APPRENDRE ?
// Dans ce puzzle il vous faut comparer différentes valeurs et mettre en corrélation des caractères et des entiers.
// Une solution simple utilise 8 conditions. Il y a une façon de la simplifier à 4 conditions.
// Ressources externes Conditions
// OPPORTUNITÉS D'APPRENTISSAGE
// Les concepts suivants peuvent vous aider à résoudre ce puzzle. Découvrez-les et mettez-les en pratique pour continuer votre progression.
// Conditions
// ÉNONCÉ
// Un problème de base pour aller un peu plus loin avec les conditions et les variables : votre programme doit permettre à Thor de rejoindre les coordonnées de l'éclair de puissance dans un champ en 2D.
// HISTOIRE
// Le marteau de Thor, Mjöllnir, a perdu tout pouvoir... Saurez-vous guider Thor vers l'éclair de puissance afin de redonner sa force au marteau ?

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
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); 
            

            int x_diff_light_me = lightX - initialTx;
            int y_diff_light_me = lightY - initialTy;

            
            if (x_diff_light_me > 0)
            {
                if(y_diff_light_me > 0)
                {
                    Console.WriteLine("SE");
                    initialTx += 1;
                    initialTy += 1;

                }
                else if (y_diff_light_me == 0)
                {
                    Console.WriteLine("E");
                    initialTx +=1;
                }
                else
                {
                    Console.WriteLine("NE");
                    initialTx += 1;
                    initialTy -= 1;
                }
            }
            else if (x_diff_light_me == 0)
            {
                if(y_diff_light_me > 0)
                {
                    Console.WriteLine("S");
                    initialTy += 1;
                }
                else
                {
                    Console.WriteLine("N");
                    initialTy -= 1;
                }
            }
            else 
            {
                if(y_diff_light_me > 0)
                {
                    Console.WriteLine("SW");
                    initialTx -= 1;
                    initialTy += 1;

                }
                else if (y_diff_light_me == 0)
                {
                    Console.WriteLine("W");
                    initialTx -= 1;
                }
                else
                {
                    Console.WriteLine("NW");
                    initialTx -= 1;
                    initialTy -= 1;
                }

            }
        }
    }
}