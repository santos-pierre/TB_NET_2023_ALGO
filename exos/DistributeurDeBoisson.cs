namespace TB_NET_2023_ALGO.exos
{
    internal class DistributeurDeBoisson
    {
        static void Main()
        {
            Console.WriteLine("EXO-DISTRIBUTEUR BOISSON");

            int stockCoca = 3;
            int stockWater = 0;

            Console.WriteLine("Quel boisson désirez vous ? 1 = coca, 2 = eau");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (stockCoca > 0)
                    {
                        stockCoca--;
                        Console.WriteLine("Voici votre coca");
                    }else
                    {
                        Console.WriteLine("Il n'y a plus de coca");
                    }
                    break;
                case 2:
                    if (stockWater > 0)
                    {
                        stockWater--;
                        Console.WriteLine("Voici votre eau");
                    }
                    else
                    {
                        Console.WriteLine("Il n'y a plus d'eau");
                    }
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
            Console.WriteLine($"Il reste {stockCoca} coca, {stockWater} eau");
        }

    }
}
