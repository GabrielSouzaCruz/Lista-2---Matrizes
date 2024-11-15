using System;
using Biblioteca_Matriz;
class Exercicio_7
    {
        static double[,] SomaM(double[,] matriz1, double[,] matriz2, int linhas, int cols)
        {
            double[,] resultado = new double[linhas, cols];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultado[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }
            return resultado;
        }
        static double[,] SubtraiM(double[,] matriz1, double[,] matriz2, int linhas, int cols)
        {
            double[,] resultado = new double[linhas, cols];
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultado[i, j] = matriz1[i, j] - matriz2[i, j];
                }
            }
            return resultado;
        }

        static void Const(double[,] matriz, double constante, int linhas, int cols)
        {
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matriz[i, j] += constante;
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("*** Matriz 1 ***");
            Console.Write("Quantidade de linhas: ");
            int linhas = int.Parse(Console.ReadLine());

            
            Console.Write("Quantidade de colunas: ");
            int cols = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("*** Matriz 2 ***");
            Console.Write("Quantidade de linhas: ");
            int linhas2 = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de colunas: ");
            int cols2 = int.Parse(Console.ReadLine());

            Console.Clear();

            double[,] matriz1 = new double[linhas, cols];
            double[,] matriz2 = new double[linhas2, cols2];


            Matriz.gera(matriz1);
            Console.WriteLine("** Matriz 1 **");
            Matriz.mostra(matriz1);

            Console.WriteLine();

            Matriz.gera(matriz2);
            Console.WriteLine("** Matriz 2 **");
            Matriz.mostra(matriz2);

            Console.WriteLine();

            Console.WriteLine("Escolha uma opção: ");

            Console.WriteLine("(1) Somar as duas matrizes");
            Console.WriteLine("(2) Subtrair a primeira matriz da segunda");
            Console.WriteLine("(3) Adicionar uma constante às duas matrizes");
            Console.WriteLine("(4) Imprimir as matrizes");

            Console.WriteLine();

            Console.Write("Digite: ");

        char opcao = char.Parse(Console.ReadLine());

            switch (opcao)
            {
                case '1':

                    double[,] soma = SomaM(matriz1, matriz2, linhas, cols);

                    Console.WriteLine("Resultado da soma das matrizes: ");
                    Console.WriteLine();
                    Matriz.mostra(soma);

                    break;

                case '2':
                    double[,] subtracao = SubtraiM(matriz2, matriz1, linhas, cols);

                    Console.WriteLine("Resultado da subtração da primeira matriz da segunda: ");
                    Console.WriteLine();
                    Matriz.mostra(subtracao);

                    break;

                case '3':
                    Console.Write("Digite o valor da constante: ");

                    double constante = double.Parse(Console.ReadLine());

                    Const(matriz1, constante, linhas, cols);
                    Const(matriz2, constante, linhas2, cols2);

                    Console.WriteLine();

                    Console.WriteLine("Matriz 1 após adicionar a constante: ");
                    Matriz.mostra(matriz1);

                    Console.WriteLine();

                    Console.WriteLine("Matriz 2 após adicionar a constante: ");
                    Matriz.mostra(matriz2);

                    break;

                case '4':
                    Console.WriteLine("Matriz 1: ");
                    Matriz.mostra(matriz1);

                    Console.WriteLine();

                    Console.WriteLine("Matriz 2: ");
                    Matriz.mostra(matriz2);

                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

             Console.ReadKey();

        }

    }

