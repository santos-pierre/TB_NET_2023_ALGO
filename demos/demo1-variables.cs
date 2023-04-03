namespace last_try.demos
{
    internal class Demo1
    {
        static void Main(string[] args)
        {
            // Exemple d'utilisation des variables en C#

            // Déclaration et initialisation d'une variable de type int
            int age = 25;
            // Afficher une variable en console => !Attention pas de guillemet!
            Console.WriteLine(age);
            Console.WriteLine("Mon âge est de {0} ans.", age);

            // Déclaration et initialisation d'une variable de type double
            double prix = 12.99;
            Console.WriteLine("Le prix est de {0:C2}.", prix);

            // Déclaration et initialisation d'une variable de type float
            // f ou F obligatoire car sinon considérer comme un double
            float taux = 1.25f;
            Console.WriteLine("Le taux est de {0:F2}.", taux);

            // Déclaration et initialisation d'une variable de type char
            char lettre = 'A';
            Console.WriteLine("La lettre est {0}.", lettre);

            // Déclaration et initialisation d'une variable de type string
            string nom = "Dupont";
            Console.WriteLine("Le nom est {0}.", nom);

            // Déclaration et initialisation d'une variable de type bool
            bool estVrai = true;
            Console.WriteLine("La valeur est {0}.", estVrai);
        }
    }
}
