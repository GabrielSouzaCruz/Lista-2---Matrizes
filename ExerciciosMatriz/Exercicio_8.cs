using System;
using Biblioteca_Matriz;

class Exercicio_8
{
    static void gera(int[,] mat)
    {
        Random rand = new Random();

        for (int x = 0; x < mat.GetLength(0); x++)
        {
            for (int y = 0; y < mat.GetLength(1); y++)
            {
                mat[x, y] = rand.Next(0, 1);
            }
        }
    }

    static void Main()
    {
        int[,] mat = new int[10, 10];
        int x;
        int y;
        int result = 0;
        gera(mat);

        Console.Write("Quantidade de raios: ");
        int cont = int.Parse(Console.ReadLine());

        for (int i = 0; i < cont; i++)
        {
            Console.Clear();

            Console.WriteLine("Digite a posição dos Raios: ");
            Console.Write("X: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Y: ");
            y = int.Parse(Console.ReadLine());

            mat[x, y]++;

        }

        for (int i = 0; i < mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat.GetLength(1); j++)
            {
                if (mat[i, j] > 1)
                {
                    result = 1;
                }
            }
        }

        Console.WriteLine();

        Console.WriteLine($"Resultado igual à: {result}");

        Console.ReadKey();

    }
}