using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o {0}° nome: ", i + 1);
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine();

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}° nome:{1} ",i + 1, nomes[i]);
            }
            Console.ReadKey();
        }
    }
}