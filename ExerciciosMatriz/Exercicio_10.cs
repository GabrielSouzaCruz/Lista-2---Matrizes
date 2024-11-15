using System;
using Biblioteca_Matriz;

    class Exercicio_10
    {
    public static void mostra(int[,] mat)
    {
        int linhas = mat.GetLength(0);
        int cols = mat.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            Console.Write($"Regiao {i + 1}:");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{mat[i, j],3} |");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.Write("Quantas regioes? ");
        int linha = int.Parse(Console.ReadLine());

        Console.Write("Quantas cidades? ");
        int cols = int.Parse(Console.ReadLine());

        Console.Clear();

        int[,] matriz = new int[linha, cols];

        Matriz.gera(matriz);
        mostra(matriz);

        int[] regiao = new int[linha];

        for (int i = 0; i < linha; i++)
        {
            int soma = 0;
            for (int j = 0; j < cols; j++)
            {
                soma += matriz[i, j];
            }
            regiao[i] = soma;
        }
        Console.WriteLine();

        Console.WriteLine("Força Total das regiões: ");

        Console.WriteLine();

        for (int i = 0; i < linha; i++)
        {
            Console.WriteLine($"Regiao {i + 1}: {regiao[i]} Tropas");
        }
        Console.ReadKey();
    }
}