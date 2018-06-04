namespace TicTacToeBugZero
{
	public class WhiteWin : TicTacToeState
	{
		public override void Accept(IStateVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}