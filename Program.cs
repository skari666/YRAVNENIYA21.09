using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение для альфа:");
        string alphaInput =Console.ReadLine();

        if (!double.TryParse(alphaInput, out double alpha) || alpha == 0)
        {
            Console.WriteLine("Неправильный формат или значение альфа равно нулю.");
            return;
        }

        Console.WriteLine("Введите значение для бетта:");
        string betaInput = Console.ReadLine();

        if (!double.TryParse(betaInput, out double beta) || beta == 0)
        {
            Console.WriteLine("Неправильный формат или значение бетта равно нулю.");
            return;
        }

        double numerator = Math.Sin(alpha) + Math.Cos(2 * beta - alpha);
        double numerator2 = Math.Cos(alpha) - Math.Sin(2 * beta - alpha);

        if (numerator2 == 0)
        {
            Console.WriteLine("Знаменатель равен нулю, деление на ноль невозможно.");
        }
        else
        {
            double result = numerator / numerator2;
            Console.WriteLine($"Значение Y = {result}");
            Console.ReadKey();
        }
    }
}
