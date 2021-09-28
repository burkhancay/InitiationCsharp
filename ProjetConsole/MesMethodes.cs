using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    public class MesMethodes
    {
        //une classe peut contenir 2 types de méthode
        //méthode de classe : methode static accessible via la classe directement
        //méthode d'instance : pas de mot static 
        public int Somme(int x, int y)
        {
            return x + y;
        }

        //Méthode qui renvoie la somme des éléments d'un tableau d'entiers
        public static int Somme(int[] tab)
        {
            int som = 0;
            foreach (var item in tab)
            {
                som += item;
            }

            return som;
        }
        //Méthode qui renvoie la moyenne des éléments d'un tableau d'entiers

        public static double Moy(int[] tab)
        {
            double som = 0;
            foreach (var item in tab)
            {
                som += item;
            }

            return som / tab.Length;
        }


        //Méthode qui renvoie l'élément le plus petit d'un tableau d'entiers

        public static int Minimum(int[] tab)
        {
            int min = tab[0];

            for (int i = 0; i < tab.Length; i++)
            {
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }

            return min;
        }

        //Parametres optionnels d'une methode
        // Se sont des param qui possedent des valeurs par defaut et doivent etre definis a la fin de la liste des params
        public static int SommeOptional(int x, int y, int z = 10)
        {
            return x + y + z;
        }

        //Methode qui permute 2 entiers
        //Ref : concerne que les types simples (types valeurs)
        public static void Permuter(ref int x, ref int y) // x=10, y=20
        {
            int temp = x; //10
            x = y; //20
            y = temp; //10

        }

        public static double Calculer(double x, double y, out double somme, out double moyenne)
        {
            moyenne = (x + y) / 2;
            somme = x + y;
            return x * y;
        }
        // Nombre variable de parametres d'une methode
        //public static int Produit(int x, int y)
        //{
        //    return x * y;
        //}
        //public static int Produit(int x, int y, int z)
        //{
        //    return x * y * z;
        //}

        //public static int Produit(int x, int y, int z, int a)
        //{
        //    return x * y * z * a;
        //}

        public static int Produit(params int[] tab)
        {
            int prod = 1;
            foreach (var item in tab)
            {
                prod *= item;
            }
            return prod;
        }
    }
}
