
namespace TB_NET_2023_ALGO.exos
{
    internal class AnneeBissextile
    {
        static void Main()
        {
            Console.WriteLine("EXO-ANNEE BISSEXTILE");
            Console.WriteLine("Quel est l'année que vous souhaiter tester ?");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} est bissextile :)");
            }
            else
            {
                Console.WriteLine($"{year} n'est pas bissextile :(");
            }
        }
    }
}
