using System;

public class Int
{
    public static void divide(int a, int b)
    {
        try
        {
            int result = a / b;
            Console.WriteLine($"{a} / {b} = {result}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine();
        }
    }
}