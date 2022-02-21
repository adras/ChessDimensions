using ChessDimensions.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChessDimensions.Controls
{
    /// <summary>
    /// Interaction logic for ChessPlayArea.xaml
    /// </summary>
    public partial class ChessPlayArea : UserControl
    {
        //ChessPlayAreaViewModel viewModel;
        //internal ChessPlayAreaViewModel ViewModel
        //{
        //    get
        //    {
        //        return viewModel;
        //    }

        //    set
        //    {
        //        viewModel = value;
        //    }
        //}

        public ChessPlayArea()
        {
            InitializeComponent();
            //DataContext = ViewModel = new ChessPlayAreaViewModel();
        }

    }
}
