namespace TicTacToeBugZero
{
	public interface IStateVisitor
	{
		void Visit(WhiteTurnTicTacToe state);

		void Visit(WhiteWin state);

		void Visit(BlackTurnTictacToe state);
		
	}
}