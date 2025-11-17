using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N_LIN = 3, N_COL = 3;
            int[,] mat = new int[N_LIN, N_COL];

            Console.WriteLine("Cadastrando dados na matriz\n");
            Console.WriteLine("Entre com o valor em cada posição da matriz:\n");

          
            for (int l = 0; l < N_LIN; l++)
            {
                for (int c = 0; c < N_COL; c++)
                {
                    Console.Write($"mat[{l},{c}] = ");
                    mat[l, c] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n\nExibindo os dados da matriz:\n");

            for (int l = 0; l < N_LIN; l++)
            {
                for (int c = 0; c < N_COL; c++)
                {
                    Console.Write($"{mat[l, c]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
