using System;
using Biblioteca_Matriz;

public class Atividade_3
{
    public static int X(int[,] matriz, int x)
    {
        int cont = 0;
        int linhas = matriz.GetLength(0); 
        int cols = matriz.GetLength(1); 

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matriz[i, j] == x)
                {
                    cont = cont + 1;
                }
            }
        }
        return cont;
    }
    static void Main()
    {
        Console.WriteLine("**Matriz**");
        Console.Write("Quantidade de linhas: ");
        int linhas = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de colunas: ");
        int cols = int.Parse(Console.ReadLine());

        Console.Clear();

        int[,] matriz = new int[linhas, cols];

        Matriz.gera(matriz);

        Console.Write("Digite um número X para contar quantas vezes ele aparece: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Matriz Gerada: ");
        Matriz.mostra(matriz);

        int x = X(matriz, x);

        Console.WriteLine($"\nNúmero de vezes que o {x} foi digitado é : {x}");

        Console.ReadKey();
    }
}
