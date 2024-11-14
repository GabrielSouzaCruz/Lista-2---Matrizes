using System;

public class Exercicio_9
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int maxX = 1001; 
        int maxY = 1001;

        bool[,] mar = new bool[maxX, maxY];

        for (int i = 0; i < n; i++)
        {
            string[] entrada = Console.ReadLine().Split();
            int x1 = int.Parse(entrada[0]);
            int y1 = int.Parse(entrada[1]);
            int x2 = int.Parse(entrada[2]);
            int y2 = int.Parse(entrada[3]);

            for (int x = x1; x < x2; x++)
            {
                for (int y = y1; y < y2; y++)
                {
                    mar[x, y] = true; 
                }
            }
        }

        int areaCoberta = 0;
        for (int x = 0; x < maxX; x++)
        {
            for (int y = 0; y < maxY; y++)
            {
                if (mar[x, y])
                {
                    areaCoberta++;
                }
            }
        }

        Console.WriteLine(areaCoberta);

    }
}
