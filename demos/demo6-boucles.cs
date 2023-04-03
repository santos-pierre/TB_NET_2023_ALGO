namespace TB_NET_2023_ALGO.demos
{
    internal class Demo6
    {
        static void Main(string[] args)
        {
            Console.Write("Entrez un nombre : ");
            int nombre = Convert.ToInt32(Console.ReadLine());

            int compteur = 1;

            while (compteur <= nombre)
            {
                Console.Write(compteur + " ");
                compteur++;
            }
        }
    }
}
