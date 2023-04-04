namespace TB_NET_2023_ALGO.exos
{
    internal class LanceurDeBalle
    {
        static void Main()
        {
            Console.WriteLine("EXO-LANCEUR DE BALLE");
            bool isReady = true;
            bool isEmpty = false;

            if (isReady && !isEmpty)
            {
                Console.WriteLine("Lancé la balle !");
            }else if (isEmpty && !isReady)
            {
                Console.WriteLine("Vous n'êtes pas prêt et le panier est vide");
            }else if (isEmpty && isReady)
            {
                Console.WriteLine("Le panier est vide :(");
            }
            else
            {
                Console.WriteLine("Vous n'êtes pas prêt :(");
            }
        }
    }
}
