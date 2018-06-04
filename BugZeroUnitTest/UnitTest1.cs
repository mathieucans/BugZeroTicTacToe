using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BugZeroUnitTest
{
	/*static class nextPlay
	{
		public static TicTacToeState Plays(this TicTacToeState state, int row, int col)
		{
			TicTacToeState newState = state;
			if (state is BlackTurnTictacToe)
			{
				newState = ((BlackTurnTictacToe)state).BlackPlays(row, col);
			}
			else if (state is WhiteTurnTicTacToe)
			{
				newState = ((WhiteTurnTicTacToe)state).WhitePlays(row, col);
			}			
			return newState;
		}
	}*/[TestClass]
	public class UnitTest1
	{
		private object WHITE_WINS;

		[TestMethod]
		public void TestMethod1()
		{
			var game = new WhiteTurnTicTacToe();

			var playGameConsole = new PlayGameConsole(
				new[]
				{
					new Position(new RowId(0), new ColId(1)),
					new Position(new RowId(1), new ColId(1)),
					new Position(new RowId(0), new ColId(2)),
					new Position(new RowId(2), new ColId(2)),
					new Position(new RowId(0), new ColId(0)),
				});

			game.Accept(playGameConsole);			

			Assert.IsInstanceOfType(playGameConsole.LastState, typeof(WhiteWin));
		}

		
	}

	public class PlayGameConsole : IStateVisitor
	{
		private Queue<Position> _positions;

		public PlayGameConsole(IEnumerable<Position> positions)
		{
			_positions = new Queue<Position>(positions);
		}

		public TicTacToeState LastState { get; set; }

		public void Visit(WhiteTurnTicTacToe state)
		{
			LastState = state.WhitePlays(AskForPosition());
			LastState.Accept(this);
		}

		private Position AskForPosition()
		{
			return _positions.Dequeue();
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

	public class ColId
	{
		public int Col
		{
			get;
			set;
		}

		public ColId(int c)
		{
			Col = c;
		}
	}

	public class RowId
	{
		public int Row { get; set; }

		public RowId(int r)
		{
			Row = r;
		}
	}


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

	public class WhiteWin : TicTacToeState
	{
		public override void Accept(IStateVisitor visitor)
		{
			visitor.Visit(this);
		}
	}

	public abstract class TicTacToeState
	{
		public abstract void Accept(IStateVisitor visitor);
	}

	public interface IStateVisitor
	{
		void Visit(WhiteTurnTicTacToe whiteWin);
		

		void Visit(WhiteWin whiteWin);
		

		void Visit(BlackTurnTictacToe whiteWin);
		
	}
}
