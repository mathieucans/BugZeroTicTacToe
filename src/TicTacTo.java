import java.util.List;

public class TicTacTo {

	private Player player1;
	private Player player2;
	private Plateau plateau;
	private WinChecker winChecker;

	public TicTacTo() {
		plateau = new Plateau();
		player1 = new Player();
		player2 = new Player();
		winChecker = new WinChecker();
	}

	public static void main(String[] args) {
		new TicTacTo().play();
	}

	private void play() {
		boolean end = false;
		while (!end) {
			System.out.println("Player 1");
			List<Box> boxs = plateau.getFreeBox();
			plateau.addPlayerBox(player1.getBox(boxs));
			List<Box> boxesPlayer1 = player1.getBoxes();
			if (winChecker.isWin(boxesPlayer1)) {
				System.out.println("Player 1 win");
				end = true;
			} else if (getLastTurn(boxesPlayer1)) {
				System.out.println("game over");
				end = true;
			}

			if (!end) {
				System.out.println("Player 2");
				boxs = plateau.getFreeBox();
				plateau.addPlayerBox(player2.getBox(boxs));
				List<Box> boxesPlayer2 = player2.getBoxes();
				if (winChecker.isWin(boxesPlayer2)) {
					System.out.println("Player 2 win");
					end = true;
				}
			}
		}
	}

	private boolean getLastTurn(List<Box> boxesPlayer) {
		return boxesPlayer.size() == 5;
	}
}
