namespace TicTacToeBugZero
{
	public class BlackTurnTictacToe : TicTacToeState
	{

		public WhiteTurnTicTacToe BlackPlays(Position pos)
		{
			return new WhiteTurnTicTacToe();
		}

		public override void Accept(IStateVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}