import java.util.ArrayList;
import java.util.List;

public class Plateau {
	private List<Box> freeCase;
	
	public Plateau() {
		freeCase = new ArrayList<>();
		freeCase.add(Box.BOXNE);
		freeCase.add(Box.BOXN);
		freeCase.add(Box.BOXNO);
		freeCase.add(Box.BOXE);
		freeCase.add(Box.BOXC);
		freeCase.add(Box.BOXO);
		freeCase.add(Box.BOXSE);
		freeCase.add(Box.BOXS);
		freeCase.add(Box.BOXSO);
	}

	public List<Box> getFreeBox() {
		return freeCase;
	}

	public void addPlayerBox(Box box) {
		freeCase.remove(box);
	}

	
}
