namespace TicTacToeBugZero
{
	public class Position
	{
		public Position(RowId row, ColId col)
		{
			Row = row;
			Col = col;
		}

		public RowId Row { get; set; }
		public ColId Col { get; set; }
	}
}