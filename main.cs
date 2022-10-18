// Created by: Claire Bedrossian
// Created on: Oct 2022
//
// This program calculates the perimeter of a square

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int sideA;
        int perimeter;

        Console.WriteLine("This program calculates the area and perimeter of a square.");
        Console.WriteLine("");

        Console.Write("Enter the length of side A (cm): ");
        sideA = Convert.ToInt32(Console.ReadLine());

        perimeter = sideA * 4;

        Console.WriteLine("");
        Console.WriteLine("The perimeter is: " + perimeter + " cm. ");

        Console.WriteLine("\nDone.");
    }
}