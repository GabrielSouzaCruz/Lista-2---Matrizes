using System;
using Biblioteca_Matriz;

class Exercicio_11
{
    static int diagonalPrinc(int[,] matriz)
    {
        int soma = 0;
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                if (i == j)
                {
                    soma += matriz[i, j];
                }
            }
        }
        return soma;
    }

    static int diagonalSecun(int[,] matriz)
    {
        int soma = 0;
        int colunas = matriz.GetLength(0);

        for (int i = 0; i < colunas; i++)
        {
            soma += matriz[i, colunas - 1 - i];
        }
        return soma;
    }
    static void Main()
    {
        Console.WriteLine("Tamanho do Mapa do Tesouro");

        Console.WriteLine("Quantidade de linhas: ");
        int linhas = int.Parse(Console.ReadLine());

        Console.WriteLine("Quantidade de colunas: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matriz = new int[linhas, cols];
        Matriz.gera(matriz);

        Console.Clear();

        Console.WriteLine("Mapa do Tesouro(Quantidade de Moedas em Cada Região):");
        Matriz.mostra(matriz);

        Console.WriteLine();

        Console.WriteLine($"Soma diagonal Principal = {diagonalPrinc(matriz)}");
        Console.WriteLine($"Soma diagonal Secundaria = {diagonalSecun(matriz)}");

        Console.WriteLine();

        if (diagonalSecun(matriz) > diagonalPrinc(matriz))
        {
            Console.WriteLine("O maior tesouro esta na diagonal secundaria, vamos la");
        }
        else
        {
            Console.WriteLine("O maior tesouro esta na diagonal principal, vamos la");
        }

        Console.ReadKey();
            
    }
}

