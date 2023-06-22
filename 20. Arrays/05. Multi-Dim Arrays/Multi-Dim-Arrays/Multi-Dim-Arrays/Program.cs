﻿class Program
{
    static void Main()
    {
        int[,] a = new int[4, 3]
        {
            {10, 20, 30 },
            {40, 50, 60 },
            {70, 80, 90 },
            {100, 110, 120 }
        };
        //read data from multi-dim array
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(a[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}