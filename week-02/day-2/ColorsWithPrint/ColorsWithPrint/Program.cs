using System;

 namespace Colors
 {
     class Program
     {
         static void Main(string[] args)
         {
             // - Create a two dimensional array
             //   which can contain the different shades of specified colors
             // - In `colors[0]` store the shades of green:
             //   `"lime", "forest green", "olive", "pale green", "spring green"`
             // - In `colors[1]` store the shades of red:
             //   `"orange red", "red", "tomato"`
             // - In `colors[2]` store the shades of pink:
             //   `"orchid", "violet", "pink", "hot pink"`
             string[][] colors = new string[3][];
             colors[0] = new string[] { "lime", "forest green", "olive", "pale green", "spring green" };
             colors[1] = new string[] { "orange red", "red", "tomato" };
             colors[2] = new string[] { "orchid", "violet", "pink", "hot pink" };
 
             PrintArray(colors);
             Console.ReadLine();
         }
         static void PrintArray(string[][] arr)
         {
             for (int i = 0; i<arr.Length; i++)
             {
                 for (int j = 0; j<arr[i].Length; j++)
                 Console.Write(arr[i][j] + " ");
             }
             Console.WriteLine();
         }
     }
 } 