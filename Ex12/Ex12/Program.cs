using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();   //Objeto responsável por geração de números aleatórios

            const int QTD_COL = 3;
            const int QTD_LIN = 3;
            int[,] matriz = new int[QTD_LIN, QTD_COL];

            matriz = cadastrarNumeros(QTD_LIN, QTD_COL);

            Console.WriteLine("\n---------MEMORIZE---------\n");
            exibirDados(matriz);

            Thread.Sleep(5000);     //aguarda 5 segundos
            Console.Clear();        //limpa a tela
            
            int sorteioLinha = random.Next(0, QTD_LIN);     //gera número aleatório de 0 até QTD_LIN que no caso é 3
            int sorteioColuna = random.Next(0, QTD_COL);      //gera número aleatório de 0 até QTD COL que no caso é 3

            Console.Write("\nQual número consta na posição: linha {0}, coluna {1} da matriz: ", sorteioLinha, sorteioColuna);
            int num = int.Parse(Console.ReadLine());

            //método verifica passa por parâmetro o valor que está em uma posição da matriz e o número digitado pelo usuário,
            //sendo que retornará true ou false
            if (verifica(matriz[sorteioLinha, sorteioColuna], num) == true)
                Console.WriteLine("\nParabéns! Você acertou!\n");
            else
                Console.WriteLine("\nQue pena! Você errou! Número correto seria: {0}\n", matriz[sorteioLinha, sorteioColuna]);

            exibirDados(matriz);
            Console.ReadKey();
            
            static int[,] cadastrarNumeros(int nLin, int nCol)
            {
                int[,] n = new int[nLin, nCol];
                Random random = new Random();
                //Atribuição de números na matriz
                for (int l = 0; l < nLin; l++)
                    for (int c = 0; c < nCol; c++)
                        n[l, c] = random.Next(0, 50);
                return n;
            }
            static Boolean verifica(int numeroMatriz, int numUsuario)
            {
                return numeroMatriz == numUsuario ? true : false;

                /* ou usando if
                if (numeroMatriz == numUsuario
                     return true;
                else
                     return false;
                */
            }
            static void exibirDados(int[,] n)
            {
                //Exibição dos dados da matriz
                for (int i = 0; i < n.GetLength(0); i++)
                {
                    for (int j = 0; j < n.GetLength(1); j++)
                    {
                        Console.Write("{0:D2}\t", n[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}