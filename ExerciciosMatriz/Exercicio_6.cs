using System;
using Biblioteca_Matriz;

    internal class Exercicio_6
    {
        public static int[,] SomaMatriz(int[,] matriz1, int[,] matriz2)
        {
            int linhas = matriz1.GetLength(0);
            int cols = matriz1.GetLength(1);

            int[,] soma = new int[linhas, cols];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    soma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return soma;
        }

        static void Main()
        {
            Console.WriteLine("--Matriz 1--");
            Console.Write("Quantidade de linhas: ");
            int linhas = int.Parse(Console.ReadLine());

            
            Console.Write("Quantidade de colunas: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matriz1 = new int[linhas, cols];

            Console.WriteLine();

            Console.WriteLine("--Matriz 2--");
            Console.Write("Quantidade de linhas: ");
            int linhas2 = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de colunas: ");
            int cols2 = int.Parse(Console.ReadLine());
            int[,] matriz2 = new int[linhas2, cols];

            Console.Clear();

                if(linhas == linhas2 && cols == cols2)
                {
                    Console.WriteLine("--Matriz 1--");
                    Matriz.gera(matriz1);
                    Matriz.mostra(matriz1); 

                    Console.WriteLine();

                    Console.WriteLine("--Matriz 2--");
                    Matriz.gera(matriz2);
                    Matriz.mostra(matriz2);

                    Console.WriteLine();

                    Console.WriteLine("A soma das duas matrizes é: ");


            int[,] resultado = SomaMatriz(matriz1, matriz2);

                for (int i = 0; i < resultado.GetLength(0); i++)
                {
                    for (int j = 0; j < resultado.GetLength(1); j++)
                    {
                        Console.Write($"{resultado[i, j],3} |");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Não é possível somar matrizes de ordem diferente!!");
            }

            Console.ReadKey();

        }
    }


