using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_it
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postIt1;
            PostIt postIt2;
            PostIt postIt3;

            postIt1.Number = 1;
            postIt1.BackgroundColor = "Yellow";
            postIt1.Text = "ihavetowritesomething";
            postIt1.TextColor = "Black";

            postIt2.Number = 2;
            postIt2.BackgroundColor = "Red";
            postIt2.Text = "ihavetowritesomething";
            postIt2.TextColor = "White";

            postIt3.Number = 3;
            postIt3.BackgroundColor = "Pink";
            postIt3.Text = "ihavetowritesomething";
            postIt3.TextColor = "Black";

            Console.WriteLine(postIt1.TextColor);
            Console.WriteLine(postIt2.Text);
            Console.WriteLine(postIt3.Number);

            Console.ReadLine();
        }
    }
}
