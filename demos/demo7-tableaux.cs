namespace TB_NET_2023_ALGO.demos
{
    internal class Demo7
    {
        static void Main(string[] args)
        {
            // Déclaration d'un tableau d'entiers de taille 5
            int[] tableau1 = new int[5];

            // Initialisation du tableau avec des valeurs
            tableau1[0] = 1;
            tableau1[1] = 2;
            tableau1[2] = 3;
            tableau1[3] = 4;
            tableau1[4] = 5;

            // Déclaration et initialisation d'un tableau de chaînes de caractères
            string[] tableau2 = { "Bonjour", "tout", "le", "monde" };

            // Déclaration d'un tableau d'entiers de taille 3 et initialisation avec des valeurs
            int[] tableau3 = new int[] { 10, 20, 30 };

            // Boucle for pour parcourir le tableau1
            Console.WriteLine("Parcours avec une boucle for :");
            for (int i = 0; i < tableau1.Length; i++)
            {
                Console.WriteLine("tableau1[{0}] = {1}", i, tableau1[i]);
            }

            // Boucle foreach pour parcourir le tableau2
            Console.WriteLine("\nParcours avec une boucle foreach :");
            foreach (string s in tableau2)
            {
                Console.WriteLine(s);
            }

            // Boucle while pour parcourir le tableau3
            Console.WriteLine("\nParcours avec une boucle while :");
            int j = 0;
            while (j < tableau3.Length)
            {
                Console.WriteLine("tableau3[{0}] = {1}", j, tableau3[j]);
                j++;
            }

            Console.ReadLine();
        }
    }
}
