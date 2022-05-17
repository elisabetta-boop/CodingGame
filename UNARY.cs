// QUE VAIS-JE APPRENDRE ?
// Résoudre ce puzzle vous fait convertir des caractères en leur valeur numérique ainsi que convertir des chiffres en valeurs binaires.
// Il vous faut aussi parcourir une liste de bit d'une valeur numérique.
// Ressources externes MasquageDécalage de bitsTable ASCII
// OPPORTUNITÉS D'APPRENTISSAGE
// Les concepts suivants peuvent vous aider à résoudre ce puzzle. Découvrez-les et mettez-les en pratique pour continuer votre progression.
// Chaînes de caractères
// Encodage
// Boucles
// Conditions
// ÉNONCÉ
// Votre programme doit transformer une chaîne de caractères en une série de zéros.
// Une chaîne de caractères a aussi une forme chiffrée et vous devez transformer cette forme dans un autre format.
// RÉSOUDRE
// HISTOIRE
// Le binaire c'est bien ! Mais le unaire c'est mieux !
// Mettez vos compétences d'encodeur à l'épreuve dans ce défi où il vous faudra transformer des messages en « unaire » (0 00 000 0...).

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


namespace binary{
    class ConversionToNotB
    {
        static void Main(string[] args)
        {
            string MESSAGE = Console.ReadLine();
            string message_bytes = string.Empty;
            string message_not_bytes = string.Empty;
            foreach (char c in MESSAGE)
            {
                string FindLong = Convert.ToString((int)c, 2);
                if (FindLong.Length < 7)
                {
                    FindLong = new string('0', 7 - FindLong.Length) + FindLong;
                }
                message_bytes += FindLong;
            }
            message_not_bytes = ConvertionBinary(message_bytes);
            Console.WriteLine(message_not_bytes.Trim());
            Console.ReadLine();
        }

        public static string ConvertionBinary(string binaryString)
        {
            char[] binaryArray = binaryString.ToArray();

            string answer = string.Empty;
            char beforeC = '\0';
            for (int i = 0; i < binaryArray.Length; i++)
            {
                char nowC = binaryArray[i];
                if (beforeC != '1' && nowC == '1')
                {
                    answer += " 0 0";
                    beforeC = '1';
                }
                else if (beforeC == '1' && nowC == '1')
                {
                    answer += "0";
                }
                else if (beforeC != '0' && nowC == '0')
                {
                    answer += " 00 0";
                    beforeC = '0';
                }
                else if (beforeC == '0' && nowC == '0')
                {
                    answer += "0";
                }
                else
                {
                    answer += "error";
                }
            }
            return answer;

        }
    }
}