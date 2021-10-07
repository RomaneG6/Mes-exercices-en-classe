using System;

namespace Algo_catégoriser_selon_l_âge
{
    class Program
    {
        static void Main(string[] args)
        {
            string Categorie = "";
            int age = 0;
            Console.WriteLine("Hi dude");
            CategorieAge(age, ref Categorie);

            //Display title as catégoriser selon l'age app.
            Console.WriteLine(Quelle est votre catégorie par rapport à votre âge ?)

            //Ask the user to give his age.
            Console.WriteLine(Quel âge as-tu?);

        }
        public static void CategorieAge(int age, ref string Categorie)
        {
            if (age <= 6) {
                Categorie = "Oh le bébé"; 
            } else if (age <= 7) {
                Categorie = "vous êtes poussin";
            } else if (age <= 9) {
                Categorie = "vous êtes papille";
            } else if (age <= 11) {
                Categorie = "vous êtes minime";
            } else if (age <= 14) {
                Categorie = "vous êtes cadet";
            } else {
                 Categorie = "vous n'avez plus l'âge requis";
            }

            
        }
    }
}
