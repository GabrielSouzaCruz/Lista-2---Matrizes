using System;
using Biblioteca_Matriz;

 class Exercicio_1_e_2 {
    static int maiorValorMatriz(int[,] mat)
    {
        int linhas = mat.GetLength(0); // pega linhas
        int cols = mat.GetLength(1); 
        int maior = mat[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (mat[i, j] > maior)
                    maior = mat[i, j];
            }
        }// terminou percorrer funcao
        return maior;
    }    
    static int menorValorMatriz(int[,] mat)
    {
        int linhas = mat.GetLength(0); // pega linhas
        int cols = mat.GetLength(1); 
        int menor = mat[0, 0];

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (mat[i, j] < menor)
                    menor = mat[i, j];
            }
        }// terminou percorrer funcao
        return menor;
    }
    static void Main()
    {
        int linhas, cols;

        Console.Write("Quantidade de linhas: ");
        linhas = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de colunas: ");
        cols = int.Parse(Console.ReadLine());

        Console.WriteLine();

        int[,] matrix = new int[linhas,cols];// criando a matriz
        Matriz.gera(matrix);

        Console.WriteLine("Matriz Gerada");
        Matriz.mostra(matrix);

        Console.WriteLine();

        int maiorValor = maiorValorMatriz(matrix);

        Console.WriteLine();

        Console.WriteLine($"Maior valor da matriz:{maiorValor}");
        Console.WriteLine($"Menor valor da matriz:{menorValorMatriz(matrix)}");

        Console.ReadKey();
    }

        
 }

