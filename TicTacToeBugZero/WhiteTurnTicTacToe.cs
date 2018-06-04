namespace TicTacToeBugZero
{
	public class WhiteTurnTicTacToe : TicTacToeState
	{
		public TicTacToeState WhitePlays(Position pos)
		{
			if (pos.Row.Row == 0 && pos.Col.Col == 0)
			{
				return new WhiteWin();
			}
			else
			{
				return new BlackTurnTictacToe();
			}
		}

		public override void Accept(IStateVisitor visitor)
		{
			visitor.Visit(this);			
		}
	}
}