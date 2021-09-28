using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            string choix = "";
            double valeur1 = 0;
            double valeur2 = 0;

            Console.WriteLine("************Calculatrice console**************");
            Console.WriteLine("-Choisir une opération");
            Console.WriteLine("-Addition tapez a");
            Console.WriteLine("-Soustraction tapez s");
            Console.WriteLine("-Multiplication tapez m");
            Console.WriteLine("-Division tapez d");

            //Récupérer le choix de l'utilisateur - si le choix n'est valide - on l'invite à faire un autre choix
            do
            {
                Console.WriteLine("Faites votre choix :");
                choix = Console.ReadLine();
            } while (!(choix == "a" || choix == "s" || choix == "m" || choix == "d"));


            // Demander la saisie de la valeur1
            Console.WriteLine("Saisissez la valeur1");
            valeur1 = Convert.ToDouble(Console.ReadLine());
            // Demander la saisie de la valeur2
            Console.WriteLine("Saisissez la valeur2");
            valeur2 = Convert.ToDouble(Console.ReadLine());
            // Afficher à la console le résultat
            switch (choix)
            {
                case "a":
                    Console.WriteLine(valeur1 + "+" + valeur2 + "=" + (valeur1 + valeur2));
                    break;
                case "s":
                    Console.WriteLine(valeur1 + "-" + valeur2 + "=" + (valeur1 - valeur2));
                    break;
                case "m":
                    Console.WriteLine(valeur1 + "*" + valeur2 + "=" + (valeur1 * valeur2));
                    break;
                case "d":
                    Console.WriteLine(valeur1 + "/" + valeur2 + "=" + (valeur1 / valeur2));
                    break;
            }

            // Maintenir la console active
            Console.ReadLine();

        }
    }
}
