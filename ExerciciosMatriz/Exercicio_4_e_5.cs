using System;
using Biblioteca_Matriz;

 class Exercicio_4_e_5
 {
    static void diagonalPrincipal(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        for (int i = 0; i < linhas; i++)
            Console.Write($"{mat[i, i]}|");
       
        Console.WriteLine();
    }
    static void diagonalSecundaria(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);
        int j = colunas - 1;
        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"{matriz[i, j]} |");
            j--;
        }
    }

    static void Main()
    {
        int linhas, cols;

        Console.Write("Quantidade de linhas: ");
        linhas = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de colunas: ");
        cols = int.Parse(Console.ReadLine());

        Console.WriteLine();

        if(linhas == cols) { 
            int[,] matriz = new int[linhas, cols];// criando a matriz

            Matriz.gera(matriz);

            Console.WriteLine("Matriz Gerada");
            Matriz.mostra(matriz);
            Console.WriteLine();

            Console.WriteLine("Diagonal Principal:");
            diagonalPrincipal(matriz);

            Console.WriteLine();

            Console.WriteLine("Diagonal Secundária:");
            diagonalSecundaria(matriz);

        }
        else
        {
            Console.WriteLine("Não é possível apresentar dados para esta dimensao");
        }

        Console.ReadKey();

    }
}

