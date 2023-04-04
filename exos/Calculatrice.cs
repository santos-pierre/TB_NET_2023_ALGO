namespace TB_NET_2023_ALGO.exos
{
    internal class Calculatrice
    {
        static void Main()
        {
            Console.WriteLine("EXO-CALCULATRICE");
            Console.WriteLine("Nombre 1 ?");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Opérateur ?");
            char op = char.Parse(Console.ReadLine());
            Console.WriteLine("Nombre 2 ?");
            int number2 = int.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"{number1} {op} {number2} = {number1 + number2}");
                    break;
                case '-':
                    Console.WriteLine($"{number1} {op} {number2} = {number1 - number2}");
                    break;
                case 'x':
                case '*':
                    Console.WriteLine($"{number1} {op} {number2} = {number1 * number2}");
                    break;
                case '/':
                    if (number2 == 0)
                    {
                        Console.WriteLine("Division par 0 interdite");
                    }else
                    {
                        Console.WriteLine($"{number1} {op} {number2} = {number1 / number2}");
                    }
                    break;
            }
        }
    }
}
