﻿using System.Globalization;

int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n,n];
for (int i = 0;i< n; i++)
{
    string[] values = Console.ReadLine().Split(' ');

    for(int j = 0; j < n; j++)
    {
        mat[i,j] = int.Parse(values[j]);
    }
}

