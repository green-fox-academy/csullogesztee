using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4

            Console.WriteLine("Add 5 numbers in a row with \",\"!");
            string numbers = Console.ReadLine();
            string[] numbersparted = numbers.Split(',');

            int number1 = int.Parse(numbersparted[0]);
            int number2 = int.Parse(numbersparted[1]);
            int number3 = int.Parse(numbersparted[2]);
            int number4 = int.Parse(numbersparted[3]);
            int number5 = int.Parse(numbersparted[4]);

            int sum = number1 + number2 + number3 + number4 + number5;
            int average = sum / 5;

            Console.WriteLine("Sum: " + sum + " , Average: " + average);
            Console.ReadLine();
        }
    }
}