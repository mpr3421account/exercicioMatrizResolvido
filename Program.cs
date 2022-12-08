using System.Globalization;

int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n, n];//percorrendo todas a matriz
for (int i = 0; i < n; i++)
{
    string[] values = Console.ReadLine().Split(' ');

    for (int j = 0; j < n; j++)
    {
        mat[i, j] = int.Parse(values[j]);
    }
}

Console.WriteLine("Main diagonal:");
for (int i = 0; i < n; i++)//percorrando somente as linhas
{
    Console.Write(mat[i, i] + " ");
}
Console.WriteLine();

