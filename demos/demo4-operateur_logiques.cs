namespace TB_NET_2023_ALGO.demos
{
    internal class Demo4
    {
        static void Main(string[] args)
        {
            // Déclaration de deux variables booléennes
            bool a = true;
            bool b = false;

            // Opérateur ET : retourne true si les deux opérandes sont true
            bool et = a && b;

            // Opérateur OU : retourne true si au moins une des deux opérandes est true
            bool ou = a || b;

            // Opérateur NON : retourne l'inverse de l'opérande
            bool non = !a;

            // Affichage des résultats
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a && b = {et}");
            Console.WriteLine($"a || b = {ou}");
            Console.WriteLine($"!a = {non}");
        }
    }
}
