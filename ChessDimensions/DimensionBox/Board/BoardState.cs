using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionBox.Board
{
	internal class BoardState
	{
		public static int BOARD_WIDTH = 8;
		public static int BOARD_HEIGHT = 8;
		
		public FieldState[,] fields;

		public BoardState(int width, int height)
		{
			fields = new FieldState[width, height];
		}
	}
}
