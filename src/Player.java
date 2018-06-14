import java.util.ArrayList;
import java.util.List;

public class Player {

	private List<Box> boxes;

	public Player() {

		boxes = new ArrayList<>();
	}
	
	public Box getBox(List<Box> boxs) {
		System.out.println(boxs);
		String userBox = System.console().readLine();
		Box box = Box.valueOf(userBox);
		boxes.add(box);
		return box;
	}

	public List<Box> getBoxes() {
		return boxes;
	}

}
