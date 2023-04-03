namespace TB_NET_2023_ALGO.demos
{
    internal class Demo3
    {
        static void Main(string[] args)
        {
            // Déclaration de deux variables de type int
            int a = 10;
            int b = 3;

            // Calcul de la somme, de la différence et du produit
            int somme = a + b;
            int difference = a - b;
            int produit = a * b;

            // Calcul du quotient en utilisant le casting de a en double
            double quotient = (double)a / b;

            // Affichage des variables et des résultats avec le formatage $
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a + b = {somme}");
            Console.WriteLine($"a - b = {difference}");
            Console.WriteLine($"a * b = {produit}");
            Console.WriteLine($"a / b = {quotient:F2}"); // Spécification de format F2 pour afficher le résultat de la division avec deux décimales
        }
    }
}
