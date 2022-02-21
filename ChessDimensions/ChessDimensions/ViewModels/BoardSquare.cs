using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ChessDimensions.ViewModels
{
    internal class BoardSquare : DependencyObject
    {
        private Color color;

        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register(
            nameof(Image),
            typeof(ImageSource),
            typeof(BoardSquare),
            new PropertyMetadata(null)
        );

        public SolidColorBrush SquareBrush
        {
            get { return (SolidColorBrush)GetValue(SquareBrushProperty); }
            set { SetValue(SquareBrushProperty, value); }
        }

        public static readonly DependencyProperty SquareBrushProperty = DependencyProperty.Register(
            nameof(SquareBrush),
            typeof(SolidColorBrush),
            typeof(BoardSquare),
            new PropertyMetadata(new SolidColorBrush(Colors.Aqua))
        );

        public BoardSquare(Color color)
        {
            this.color = color;
            SquareBrush = new SolidColorBrush(color);
       
        }

        public BoardSquare()
        {
            
        }
    }
}
