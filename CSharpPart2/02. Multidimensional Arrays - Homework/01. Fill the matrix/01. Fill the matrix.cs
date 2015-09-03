//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

using System;

class FillTheMatrix
{
    static void Print(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,4}",matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.WriteLine("Enter n:");
        int n=int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int increase = 1;
        //variant a)
        Console.WriteLine("a)");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col <n; col++)
            {
                matrix[col, row] = 0;
                matrix[col, row] += increase;
                increase++;
            }
            
        }
        Print(matrix);
        //Variant b)
        Console.WriteLine("b)");
        increase = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = increase;
                    increase++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = increase;
                    increase++;
                }
            }
        }
        Print(matrix);
        //variant c)
        increase = 1;
        int r = n - 1;
        int c = 0;
        Console.WriteLine("c)");
        for (int i = 0; i < n * n; i++)
        {
            matrix[r, c] = increase;
            r++;
            c++;
            increase++;

            if (r == n || c == n)
            {
                r--;
                if (c == n)
                {
                    r--;
                    c--;
                }
                while (r - 1 >= 0 && c - 1 >= 0)
                {
                    r--;
                    c--;
                }
            }
        }
        
        Print(matrix);
        //variant d)
        Console.WriteLine("d)");
        int digit = 1;
        int offset = 0;
        int ROW = 0;
        int COL = 0;
        while (digit <= n * n)            
        {
            for (ROW = offset; ROW < n - offset; ROW++)
            {
                COL = offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (COL = 1 + offset; COL < n - offset; COL++)
            {
                ROW = n - 1 - offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (ROW = n - 2 - offset; ROW >= offset; ROW--)
            {
                COL = n - 1 - offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            for (COL = n - 2 - offset; COL >= offset + 1; COL--)
            {
                ROW = offset;
                matrix[ROW, COL] = digit;
                digit++;
            }
            offset++;
        }
        Print(matrix);

    }
}

