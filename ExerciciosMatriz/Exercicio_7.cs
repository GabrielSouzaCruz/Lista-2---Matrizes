using System;
using Biblioteca_Matriz;
    internal class Exercicio_7
    {

        static double[,] SomaMatriz(double[,] matriz1, double[,] matriz2, int linhas, int colunas)
        {
            double[,] resultado = new double[linhas, colunas];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return resultado;
        }
        static double[,] SubtraiMatriz(double[,] matriz1, double[,] matriz2, int linhas, int colunas)
        {
            double[,] resultado = new double[linhas, colunas];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    resultado[i, j] = matriz1[i, j] - matriz2[i, j];
                }
            }
            return resultado;
        }

        static void Constante(double[,] matriz, double constante, int linhas, int colunas)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matriz[i, j] += constante;
                }
            }
        }
        static void Main()
        {

            Console.Write("Quantidade de linhas: ");
            int linhas = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de colunas: ");
            int cols = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Quantidade de linhas: ");
            int linhas2 = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de colunas: ");
            int cols2 = int.Parse(Console.ReadLine());

            Console.WriteLine();


            double[,] matriz1 = new double[linhas, cols];
            double[,] matriz2 = new double[linhas, cols2];


            Matriz.gera(matriz1);
            Console.WriteLine("*** 1-Matriz ***");
            Matriz.mostraf(matriz1);

            Matriz.gera(matriz2);
            Console.WriteLine("*** 2-Matriz ***");
            Matriz.mostraf(matriz2);

            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("(a) Somar as duas matrizes");
            Console.WriteLine("(b) Subtrair a primeira matriz da segunda");
            Console.WriteLine("(c) Adicionar uma constante às duas matrizes");
            Console.WriteLine("(d) Imprimir as matrizes");

            char opcao = char.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 'a':
                    double[,] soma = SomaMatriz(matriz1, matriz2, linhas, cols);

                    Console.WriteLine("Resultado da soma das matrizes:");
                    Matriz.mostraf(soma);

                    break;
                case 'b':
                    double[,] subtracao = SubtraiMatriz(matriz2, matriz1, linhas, cols);

                    Console.WriteLine("Resultado da subtração da primeira matriz da segunda:");
                    Matriz.mostraf(subtracao);

                    break;
                case 'c':
                    Console.WriteLine("Digite o valor da constante:");

                    double constante = double.Parse(Console.ReadLine());

                    Constante(matriz1, constante, linhas, cols);
                    Constante(matriz2, constante, linhas, cols);

                    Console.WriteLine("Matriz 1 após adicionar a constante:");
                    Matriz.mostraf(matriz1);
                    Console.WriteLine("Matriz 2 após adicionar a constante:");
                    Matriz.mostraf(matriz2);

                    break;
                case 'd':
                    Console.WriteLine("Matriz 1:");
                    Matriz.mostraf(matriz1);
                    Console.WriteLine("Matriz 2:");
                    Matriz.mostraf(matriz2);

                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

    }

