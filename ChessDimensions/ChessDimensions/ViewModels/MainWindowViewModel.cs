using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDimensions.ViewModels
{
    internal class MainWindowViewModel
    {
        public ChessPlayAreaViewModel ChessPlayAreaViewModel { get; set; }

        public MainWindowViewModel()
        {
            ChessPlayAreaViewModel = new ChessPlayAreaViewModel();
        }
    }
}
