using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GreenFox
{
    public class FoxDraw
    {
        private const int TILEWIDTH = 50;
        private const int TILEHEIGHT = 50;

        private Canvas Canvas { get; set; }
        private SolidColorBrush LineColor { get; set; } = SystemColors.WindowFrameBrush;
        private SolidColorBrush ShapeColor { get; set; } = new SolidColorBrush(Colors.DarkGreen);

        public FoxDraw(Canvas canvas)
        {
            Canvas = canvas;
        }

        public void AddImage(string source, double x, double y)
        {
            var image = new Image()
            {
                Width = TILEWIDTH,
                Height = TILEHEIGHT,
                Source = new BitmapImage(new Uri(source, UriKind.Relative))
            };

            Canvas.Children.Add(image);
            SetPosition(image, x, y);
        }

        public void AddImage(Canvas canvas, double x, double y)
        {
            Canvas.Children.Add(canvas);
            SetPosition(canvas, x, y);
        }

        public void SetPosition(UIElement uIElement, double x, double y)
        {
            Canvas.SetLeft(uIElement, x);
            Canvas.SetTop(uIElement, y);
        }
    }
}