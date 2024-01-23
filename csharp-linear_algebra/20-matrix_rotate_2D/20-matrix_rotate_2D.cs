public class MatrixMath
{
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[,] { { -1 } };
        }

        double cosTheta = Math.Cos(angle);
        double sinTheta = Math.Sin(angle);
        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                double x = i * cosTheta - j * sinTheta;
                double y = i * sinTheta + j * cosTheta;
                result[i, j] = matrix[(int)Math.Round(x), (int)Math.Round(y)];
            }
        }
        return result;
    }
}
