using System;

namespace TicTacToeBugZero
{
	public class PlayGameConsole : IStateVisitor
	{		
		private readonly Func<Position> _askForPosition;

		public PlayGameConsole(Func<Position> askForPosition)
		{
			_askForPosition = askForPosition;
		}

		public TicTacToeState LastState { get; set; }

		public void Visit(WhiteTurnTicTacToe state)
		{
			LastState = state.WhitePlays(AskForPosition());
			LastState.Accept(this);
		}

		private Position AskForPosition()
		{
			return _askForPosition();
		}

		public void Visit(WhiteWin whiteWin)
		{			
			Console.WriteLine("White win");
		}

		public void Visit(BlackTurnTictacToe state)
		{
			LastState = state.BlackPlays(AskForPosition());
			LastState.Accept(this);
		}
	}
}