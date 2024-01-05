﻿using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		 // Print the value of str 3 times
        Console.WriteLine(str + str + str);

        // Print the first 9 characters of str
        Console.WriteLine(str.Substring(0, 9));
        }
}