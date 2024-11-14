using System;

class Exercicio_8
{
    static void Main()
    {
        int[,] mat = new int[5, 8];
        int x;
        int y;
        int result = 0;

        build(mat);

        Console.WriteLine("Quantos raios");
        int cont = int.Parse(Console.ReadLine());

        for (int i = 0; i < cont; i++)
        {
            Console.WriteLine("Digite a posição");
            x = int.Parse(Console.ReadLine());
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
        Console.WriteLine(result);
    }
    static void build(int[,] mat)
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

}