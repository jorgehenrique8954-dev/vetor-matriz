using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = { { 1, 42, 23, 14, 51 }, { 22, 32, 55, 54, 12 } };
            int x, y;
            Console.WriteLine("\n Exibindo apenas os elementos pares da matriz:\n");
            for (x = 0; x < 2; x++)
            {
                for (y = 0; y < 5; y++)
                {
                    if (mat[x, y] % 2 == 0)
                        Console.Write(" {0:D2} ", mat[x, y]);
                    else
                        Console.Write(" -");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
