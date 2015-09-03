/* •	We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets 
of several neighbour elements located on the same line, column or diagonal.
• Write a program that finds the longest sequence of equal strings in the matrix.*/

using System;

class SequenceNMatrix
{
    static void Main()
    {
        
        Console.WriteLine("enter rows:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("enter colums:");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n,m] ;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.WriteLine("entre matrix[{0}][{1}]:",row,col);
                matrix[row,col]=Console.ReadLine();
            }
        }
        
        for (int rol = 0; rol < n; rol++)
        {
        }
        int count = 1;
        int maxCount = 1;
        string maxValue = null;
        int direction = 1;
        int rowsLenght = matrix.GetLength(0);
        int colsLenght = matrix.GetLength(1);
        for (int row = 0; row < rowsLenght; row++)
        {
            for (int col = 0; col < colsLenght - 1; col++)     
            {
                if ((matrix[row, col] == matrix[row, col + 1]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = matrix[row, col];
                    direction = 1;
                }
            }
            count = 1;
        }

        for (int col = 0; col < colsLenght; col++)                
        {
            for (int row = 0; row < rowsLenght - 1; row++)
            {
                if ((matrix[row, col] == matrix[row + 1, col]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = matrix[row, col];
                    direction = 2;
                }
            }
            count = 1;
        }

        
        for (int row = 0, col = 0; row < rowsLenght - 1 && col < colsLenght - 1; row++, col++)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxValue = matrix[row, col];
                direction = 3;
            }
        }
        count = 1;

        
        for (int row = 0, col = 0; row < rowsLenght - 1 && col > 0; row++, col--)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxCount)
            {
                maxCount = count;
                maxValue = matrix[row, col];
                direction = 4;
            }
        }
        count = 1;

        switch (direction)
        {
            case 1:
                Console.WriteLine("Element \"{0}\" repeats {1} times horizontally.", maxValue, maxCount);
                break;
            case 2:
                Console.WriteLine("Element \"{0}\" repeats {1} times vertically.", maxValue, maxCount);
                break;
            case 3:
                Console.WriteLine("Element \"{0}\" repeats {1} times diagonally from right to left.", maxValue, maxCount);
                break;
            case 4:
                Console.WriteLine("Element \"{0}\" repeats {1} times diagonally from left to right.", maxValue, maxCount);
                break;
            default:
                Console.WriteLine("No repeats found.");
                break;
        }
    }
}