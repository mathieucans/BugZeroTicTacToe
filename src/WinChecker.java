import java.util.ArrayList;
import java.util.List;

public class WinChecker {
	private List<WinList> winnerPossibilities;
	
	public WinChecker()
	{
		winnerPossibilities = new ArrayList<>();
		winnerPossibilities.add(new WinList(Box.BOXNE, Box.BOXE, Box.BOXSE));
		winnerPossibilities.add(new WinList(Box.BOXN, Box.BOXC, Box.BOXS));
		winnerPossibilities.add(new WinList(Box.BOXNO, Box.BOXO, Box.BOXSO));
		winnerPossibilities.add(new WinList(Box.BOXNE, Box.BOXN, Box.BOXNO));
		winnerPossibilities.add(new WinList(Box.BOXE, Box.BOXC, Box.BOXO));
		winnerPossibilities.add(new WinList(Box.BOXSE, Box.BOXS, Box.BOXSO));
		winnerPossibilities.add(new WinList(Box.BOXNE, Box.BOXC, Box.BOXSO));
		winnerPossibilities.add(new WinList(Box.BOXSE, Box.BOXC, Box.BOXNO));
	}
	
	public boolean isWin(List<Box> playerBox) {
		for(WinList possibility : winnerPossibilities) {
			if(possibility.includeIn(playerBox)) {
				return true;
			}
		}
		return false;
	}
}
