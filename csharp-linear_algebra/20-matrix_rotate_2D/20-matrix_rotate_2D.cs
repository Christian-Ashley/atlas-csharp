using System;

public class MatrixMath
{
   public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		if (matrix.GetLength(1) > 2)
			return new double[,] { { -1 } };
		double[,] rotation = {{Math.Cos(angle), Math.Sin(angle)}, {-1 * Math.Sin(angle), Math.Cos(angle)}};
		double[,] res = new double[2, 2];

		for (int i = 0; i < 2; i++)
			for (int j = 0; j < 2; j++)
				for (int k = 0; k < 2; k++)
					res[i, j] = Math.Round(res[i, j] + (matrix[i, k] * rotation[k, j]), 2);
		return res;
	} 
}