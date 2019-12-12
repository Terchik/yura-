using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите n");
                int n = int.Parse(Console.ReadLine());
                double sum = 1;
                for (int i = 1; i < n; i++)
                {
                    sum = sum + 1 / i;
                }
                Console.Write("Сумма ряда равна:{0}", sum);
            Console.ReadKey();
        
        }
    }
}
