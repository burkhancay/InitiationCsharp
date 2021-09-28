

using ProjetDLL;
using System;

namespace ProjetConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ceci est un commentaire sur une seule ligne
            /*
             * Ceci est un commentaire sur plusieurs lignes
             * 
             */ 


            Console.WriteLine("test de C#");

            Tools.MaMethode();

            #region Variables

            // variable : zone mémoire qui contient une valeur typée
            // Types simples (types valeur): entiers, réels, bool, char
            // Types complexes (types références): tableau, string, dates, Classes (objets)

            // entiers : byte(1 octet), short(2 octets), int (4 octets), long (8 octets)
            // reels: floats(4 octets), double(8 octets), decimal (16 octets)

            // declaration d'une variable: type nom_variable = valeur
            int myInt = 10;
            Console.WriteLine("Contenu de myInt: " + myInt); // +  : concaténation

            double myDouble = 10.5;
            char myChar = 'b';
            bool myBool = true;
            string maChaine = "chaine de caractere";

            //Mot clé var: Inférence de type - c'est le compilateur qui détermine le type de la variable
            // selon sa valeur
            var maVariable = "10.5";
            //maVariable = 5; erreur de compilation

            //Types nullables : .NET propose une syntaxe qui permet de définir des types simples null
            int? x = null;
            
            //Avant utilisation de x, on doit vérifier qu'elle contient une valeur
            if (x.HasValue)
            {
                Console.WriteLine("x n'est pas null");
            }
            else
            {
                Console.WriteLine("x est null");
            }

            string str = null;

            int age = 0;
            Console.WriteLine("Quel est votre age ?");
            age = Convert.ToInt32(Console.ReadLine()); // si le user oublie de fournir l'age on aura une erreur
            Console.WriteLine("Votre age est : " + age);

            //Constante: variable contenant une valeur qu'on ne peut pas modifier
            const double MA_CONSTANTE = 10.5;
            //MA_CONSTANTE = 25; compilateur renvoie une erreur car 25 n'est pas un double

            #endregion

            #region Opérateurs

            //opérateurs mathématique: +, -, *, /, % (Modulo: reste de la division entière)
            Console.WriteLine("Reste de la division de 10 par 3: " + (10 % 3));


            //opérateurs combinés: +=, -=, *=, /=
            myInt += 5; // myInt = myInt + 5

            //opérateurs d'incrémentation et de décrementation:
            int val = 0;
            Console.WriteLine("Pré incrémentation: " + (++val)); // incrémente val ensuite utilise sa valeur
            Console.WriteLine("Post incrémentation: " + (val++)); // utilise val ensuite l'incrémente de 1
            Console.WriteLine(++val + val++); //6
            Console.WriteLine(6 + "5" + 2); //652
            Console.WriteLine(6 + 2 + "5"); //85
            Console.WriteLine("6" + 5 + 2); //652

            //opérateurs de comparaison: == (égalité), <, >, <=, >=, != (différent)
            // opérateurs logiques: && (et logique), || (ou logique), !(non logique), ^(ou exclusif)

            int v1 = 10, v2 = 15;
            Console.WriteLine((v1 > v2) && (v1 < v2));
            //table logique
            //A     B    A&&B    A||B    A^B
            //v     v    v        v       f
            //v     f    f        v       v
            //f     v    f        v       v
            //f     f    f        f       f
            //

            #endregion

            #region Conversion de types

            //Conversion implicite: concerne le passage d'un type inférieur à un type supérieur
            byte myByte = 10;
            int myInt3 = myByte;

            //Conversion explicite: passage d'un type supérieur à un type inférieur
            //Pour les conversions explicites on peut utiliser:
            //CAST: (int), (byte), (double)...
            //La classe Convert

            int myInt4 = 20;
            byte myByte2 = (byte)myInt4;
            byte myByte3 = Convert.ToByte(myInt4);

            string chaine = "25";
            int myInt5 = Convert.ToInt32(chaine);
            int myInt6 = int.Parse(chaine);

            #endregion

            #region Conditions

            //Exprimer un test conditionnel: if(condition == vraie){instructions;}else{instructions;}
            int nb = 5;
            if (nb > 0)
            {
                Console.WriteLine("nb est positif");
            }
            else if (nb == 0)
            {
                Console.WriteLine("nb est null");
            }
            else
            {
                Console.WriteLine("nb est négatif");
            }

            //Switch : est une variante de la condition if
            int note = 10;
            switch (note)
            {
                case 0:
                    Console.WriteLine("recalé");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("Les 10, 11, 12");
                    break;
                default:
                    Console.WriteLine("Autre note");
                    break;
            }

            #endregion

            #region Boucles

            //Boucles conditionnelles : while, do while
            //Boucles itératives: for, foreach

            //for
            //for (int i = 0; i < 10; i++)
            //{
                //Passer à l'itération suivante si i = 3
             //   if (i == 3)
              //  {

              //  }
             //       Console.WriteLine("Passage numéro : " + i);
                //quitter la boucle for si i=6
             //   if (i == 6)
             //   {
             //       break;// permet de sortir de la boucle for
             //   }
           // }

            //foreach
            //int[] tab = { 1, 2, 3, 4 };
            //foreach (int item in tab) // pour chaque int contenu dans le tableau tab
            //{
            //    Console.WriteLine(item);
            //}

            //while
            //int valeur = 1;
            //while(valeur < 5) // tant que valeur est inférieur à 5
           // {
            //    Console.WriteLine("Passage numéro : " + valeur);
            //    valeur++;
           // }

            //do while

           // do
            //{
            //    Console.WriteLine("Passage numéro " + valeur);
            //} while (valeur < 10);


            #endregion

            #region Tableaux

            // Tableau : un ensemble d'éléments typés
            //1 dimension
            //Déclaration d'un tableau

            int[] tableau = new int[3]; //tableau de 3 cases
            tableau[0] = 10;
            tableau[1] = 20;
            tableau[2] = 30;
            Console.WriteLine("Taille du tableau " + tableau.Length); //3

            //Parcours du tableau avec boucle foreach
            foreach(int item in tableau)
            {
                Console.WriteLine(item);
            }

            //Parcous du tableau avec boucle for
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }

            //2eme facon de declarer un tableau
            int[] tableau2 = { 10, 20, 30 };

            // 2 dimensions

            int[,] matrice = new int[2, 3];
            matrice[0, 0] = 10;
            matrice[0, 1] = 20;
            matrice[0, 2] = 30;
            matrice[1, 0] = 40;
            matrice[1, 1] = 50;
            matrice[1, 2] = 60;

            int[,] matrice2 = { { 10, 15, 58 }, { 12, 25, 32 } }; // autre facon de déclarer un tableau à 2 dimensions

            Console.WriteLine("");

            #endregion

            #region Méthodes

            //Méthode: ensemble d'insctructions reutilisables
            // Dans la programmation objet on a 2 types de méthode
            //Procédures : methode qui ne renvoie aucune valeur (void)
            //fonctions: methode qui renvoie un resultat - on doit preciser le type du resultat renvoyé
            //déclaration d'une methode: visilité [mot cle static] type_retour Nom_Methode(parametres) {instruction}

            int resultat = MesMethodes.Somme(10, 20);
            Console.WriteLine(resultat);

            #endregion
            // Maintenir la console active
            Console.ReadLine();

            
        }
    }
}
