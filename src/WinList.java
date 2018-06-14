import java.util.List;

public class WinList {

	private Box firstBox;
	private Box secondBox;
	private Box thirdBox;

	public WinList(Box firstBox, Box secondBox, Box thirdBox) {
		this.firstBox = firstBox;
		this.secondBox = secondBox;
		this.thirdBox = thirdBox;
	}

	public boolean includeIn(List<Box> playerBox) {
		return playerBox.contains(firstBox) && playerBox.contains(secondBox) && playerBox.contains(thirdBox);
	}

}
