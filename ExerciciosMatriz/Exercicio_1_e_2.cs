using System;
using Biblioteca_Matriz;

 class Exercicio_1e2 {
    static int maiorValorMatriz(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1); 
        int maior = mat[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (mat[i, j] > maior)
                    maior = mat[i, j];
            }
        }
        return maior;
    }    
    static int menorValorMatriz(int[,] mat)
    {
        int linhas = mat.GetLength(0); 
        int cols = mat.GetLength(1); 
        int menor = mat[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (mat[i, j] < menor)
                    menor = mat[i, j];
            }
        }
        return menor;
    }
    static void Main()
    {
        int linhas, cols;

        Console.WriteLine("**Matriz**");
        Console.Write("Quantidade de linhas: ");
        linhas = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de colunas: ");
        cols = int.Parse(Console.ReadLine());

        Console.Clear();

        int[,] matrix = new int[linhas,cols];
        Matriz.gera(matrix);

        Console.WriteLine("Matriz Gerada");
        Matriz.mostra(matrix);

        Console.WriteLine();

        int maiorValor = maiorValorMatriz(matrix);

        Console.WriteLine($"Maior valor da matriz:{maiorValor}");
        Console.WriteLine($"Menor valor da matriz:{menorValorMatriz(matrix)}");

        Console.ReadKey();
    }

        
 }

