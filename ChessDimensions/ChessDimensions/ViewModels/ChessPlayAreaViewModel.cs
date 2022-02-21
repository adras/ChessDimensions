using MapCreationTool.WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChessDimensions.ViewModels
{
    internal class ChessPlayAreaViewModel : PropertyChangedBase
    {
        public readonly Color LIGHT_SQUARE_COLOR = Colors.LightGray;
        public readonly Color DARK_SQUARE_COLOR = Colors.DarkGray;

        private ObservableCollection<BoardSquare> squares;

        public ObservableCollection<BoardSquare> Squares
        {
            get
            {
                return squares;
            }
            set
            {
                squares = value;
                OnPropertyChanged();
            }
        }

        public ChessPlayAreaViewModel()
        {
            Squares = new ObservableCollection<BoardSquare>();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Color color = ((i + j) % 2 == 0) ? LIGHT_SQUARE_COLOR : DARK_SQUARE_COLOR;
                    Squares.Add(new BoardSquare(color));
                }
            }
        }
    }
}
