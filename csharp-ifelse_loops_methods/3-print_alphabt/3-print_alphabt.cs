using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char c = 'a'; c <= 'z'; c++)
{
    if (c != 'e' && c != 'q')
    {
        Console.Write(c);
    }
}
        }
    }
}
