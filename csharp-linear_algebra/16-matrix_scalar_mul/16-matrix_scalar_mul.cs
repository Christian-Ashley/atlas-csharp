﻿public class MatrixMath
{
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        double[,] result = new double[rows, columns];

        if (rows != 2 && rows != 3 || columns != 2 && columns != 3)
        {
            result = new double[,] { { -1 } };
        }
        else
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
        }
        return result;
    }
}