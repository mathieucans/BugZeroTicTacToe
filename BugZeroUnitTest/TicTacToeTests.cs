using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToeBugZero;

namespace BugZeroUnitTest{
	[TestClass]
	public class TicTacToeTests
	{
		private object WHITE_WINS;

		[TestMethod]
		public void check_that_white_state_is_return_when_white_wins()
		{
			var game = new WhiteTurnTicTacToe();

			// Configure user positions :
			var positions = new Queue<Position>(new[]
			{
				new Position(new RowId(0), new ColId(1)),
				new Position(new RowId(1), new ColId(1)),
				new Position(new RowId(0), new ColId(2)),
				new Position(new RowId(2), new ColId(2)),
				new Position(new RowId(0), new ColId(0)),
			});
			var playGameConsole = new PlayGameConsole(
				() => positions.Dequeue());

			game.Accept(playGameConsole);			

			Assert.IsInstanceOfType(playGameConsole.LastState, typeof(WhiteWin));
		}
	}
}
