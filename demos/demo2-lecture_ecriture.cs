namespace TB_NET_2023_ALGO.demos
{
    internal class Demo2
    {
        static void Main(string[] args)
        {
            // Exemple de lecture/écriture de valeurs à partir de la console en C#

            Console.Write("Entrez un entier : ");
            int entier = int.Parse(Console.ReadLine());
            // Autre manière Convert version plus générique car elle peut convertir plus d'élément.
            // int entier = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez un réel : ");
            double reel = double.Parse(Console.ReadLine());
            // double reel = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez un message : ");
            string message = Console.ReadLine();

            Console.WriteLine("Vous avez entré :");
            Console.WriteLine("Entier : {0}", entier);
            Console.WriteLine("Réel : {0}", reel);
            Console.WriteLine("Message : {0}", message);
        }
    }

}
