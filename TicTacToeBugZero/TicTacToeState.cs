namespace TicTacToeBugZero
{
	public abstract class TicTacToeState
	{
		public abstract void Accept(IStateVisitor visitor);
	}
}