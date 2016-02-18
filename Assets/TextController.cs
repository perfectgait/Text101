using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {
		cell, 
		sheets_0, 
		lock_0, 
		mirror, 
		cell_mirror, 
		sheets_1, 
		lock_1, 
		corridor_0, 
		stairs_0, 
		floor, 
		closet_door, 
		stairs_1, 
		corridor_1,
		in_closet,
		stairs_2,
		corridor_2,
		courtyard,
		corridor_3
	}
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {	
		if (myState == States.cell) {
			stateCell();
		} else if (myState == States.sheets_0) {
			stateSheets0();
		} else if (myState == States.lock_0) {
			stateLock0();
		} else if (myState == States.mirror) {
			stateMirror();
		} else if (myState == States.cell_mirror) {
			stateCellMirror();
		} else if (myState == States.sheets_1) {
			stateSheets1();
		} else if (myState == States.lock_1) {
			stateLock1();
		} else if (myState == States.corridor_0) {
			stateCorridor0();
		} else if (myState == States.stairs_0) {
			stateStairs0();
		} else if (myState == States.floor) {
			stateFloor();
		} else if (myState == States.closet_door) {
			stateClosetDoor();
		} else if (myState == States.stairs_1) {
			stateStairs1();
		} else if (myState == States.corridor_1) {
			stateCorridor1();
		} else if (myState == States.in_closet) {
			stateInCloset();
		} else if (myState == States.stairs_2) {
			stateStairs2();
		} else if (myState == States.corridor_2) {
			stateCorridor2();
		} else if (myState == States.corridor_3) {
			stateCorridor3();
		} else if (myState == States.courtyard) {
			stateCourtyard();
		}
	}
	
	void stateCell() {
		text.text = "You awake alone, like a rat in a cage.  Your head is pounding as you try to put together the "
				  + "pieces.  How did I get here?  Not caring much right now you look around for a way out.  Your "
				  + "bed is covered in dirty sheets and you see a mirror on the wall.  You check the cell door to "
				  + "see if they were really that dumb, no luck.\n\n"
				  + "Press S to view the Sheets, M to look at the Mirror or L to go to the Lock.";
				
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown(KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_0;
		}
	}
	
	void stateSheets0() {
		text.text = "Just touching these sheets makes your skin crawl.  How can anyone sleep with these?\n\n"
				  + "Press R to Return to the cell.";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void stateLock0() {
		text.text = "You walk over to the lock and can tell it's a digital keypad but you can't see the front.  You "
				  + "need a better angle.\n\n"
				  + "Press R to Return to the cell.";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
	}
	
	void stateMirror() {
		text.text = "You see your reflection and notice a huge gash just above your right eye.  It looks like someone "
				  + "didn't care much for your prescence.  You also notice that the mirror is loose against the wall. "
				  + "With enough force, you could take it off.\n\n"
				  + "Press T to Take the mirror or R to Return to the cell.";
				  
	  	if (Input.GetKeyDown(KeyCode.T)) {
	  		myState = States.cell_mirror;
	  	} else if (Input.GetKeyDown(KeyCode.R)) {
	  		myState = States.cell;
	  	}
	}
	
	void stateCellMirror() {
		text.text = "You take the mirror off the the wall being careful not to make too much noise.  You don't want to "
				  + "get caught by whoever did this to you.  Looking around the cell you see what you could use this "
				  + "with.\n\n"
				  + "Press S to use the mirror with the Sheets or L to use the mirror with the Lock.";
		
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown(KeyCode.L)) {
			myState = States.lock_1;
		}
	}
	
	void stateSheets1() {
		text.text = "You look at the sheets and then back at the mirror.  You ask yourself how that would work.\n\n"
				  + "Press R to Return to the cell.";
				  
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
	
	void stateLock1() {
		text.text = "You slide the mirror through the cell bars to get a better angle on the lock.  Seeing the lock "
				  + "you can tell someone really likes greasy food.  You can use this to your advantage.\n\n"
				  + "Press R to Return to the cell or O to follow the greasy fingerprints and Open the lock.";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		} else if (Input.GetKeyDown(KeyCode.O)) {
			myState = States.corridor_0;
		}
	}
	
	void stateCorridor0() {
		text.text = "You've escaped your cell.  You are in a corridor with cell doors as far as you can see.  You "
				  + "can smell the sweat and urine like a stew that has been brewing for days.  To your left is a "
				  + "closet door and to your right are stairs.\n\n"
				  + "Press S to climb the Stairs, F to look around on the Floor or C to check the closet door.";
				  
	    if (Input.GetKeyDown(KeyCode.S)) {
	    	myState = States.stairs_0;
	    } else if (Input.GetKeyDown(KeyCode.F)) {
	    	myState = States.floor;
		} else if (Input.GetKeyDown(KeyCode.C)) {
			myState = States.closet_door;
		}
	}
	
	void stateStairs0() {
		text.text = "You slowly climb to the top of the stairs and peek out to see what's there.  You see a courtyard "
				  + "with guards and dogs.  You better not go out there in your prisoner uniform.\n\n"
				  + "Press R to slowly Return to the corridor.";
	
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_0;
		}
	}
	
	void stateFloor() {
		text.text = "You look around the dirty floor and see wrappers and some used toilet paper.  The other prisoners "
				  + "don't care much for the guards.  Out of the corner of your eye a flash of light.  You look closer "
				  + "and see a hairclip that the sun is reflecting off of.  One of the prongs has been filed down to a "
				  + "point.  Someone was going to use this as a shiv.\n\n"
				  + "Press R to Return to the corridor and look around or H to pick up the Hairclip.";
	
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_0;
		} else if (Input.GetKeyDown(KeyCode.H)) {
			myState = States.corridor_1;
		}
	}
	
	void stateClosetDoor() {
		text.text = "You walk over to the closet door and try the knob.  It barely turns then abruptly stops.  You try "
				  + "forcing it open but realize quickly that will make too much noise.\n\n"
				  + "Press R to Return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_0;
		}
	}
	
	void stateStairs1() {
		text.text = "After peeking last time you better not take any chances until you can go unnoticed.\n\n"
				  + "Press R to Return to the corridor.";
	
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_1;
		}
	}
	
	void stateCorridor1() {
		text.text = "With the hairclip in hand you may have a chance at opening the closet door without being caught. "
				  + "Someone took the liberty of sharpening one of the prongs which you can use to your advantage.\n\n"
				  + "Press P to Pick the lock with the hairclip or S to climb the Stairs.";
		
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.in_closet;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_1;
		}
	}
	
	void stateInCloset() {
		text.text = "The closet door makes a slight creaking sound as it opens.  You slowly open the door to see what "
				  + "is inside.  You see a broom, mop and janitors outfit with a nametag, \"Ray\".\n\n"
				  + "Press R to Return to the corridor or D to Dress up in the janitors outfit.";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			myState = States.corridor_3;
		}
	}
	
	void stateStairs2() {
		text.text = "You've been over this before, it's not a good idea, yet ...\n\n"
				  + "Press R to Return to the corridor.";
		
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.corridor_2;
		}
	}
	
	void stateCorridor2() {
		text.text = "You quickly duck out of the closet because you thought you heard a noise.  You can feel your "
				  + "heart pounding in your chest.  You want so badly to get out but you realize you have to take your "
				  + "time and do this properly.\n\n"
				  + "Press B to go Back into the closet or S to climb the Stairs.";
		
		if (Input.GetKeyDown(KeyCode.B)) {
			myState = States.in_closet;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.stairs_2;
		}
	}
	
	void stateCorridor3() {
		text.text = "Ray is a big guy, you are swimming in his outfit.  It doesn't have to be perfect, \"just be "
				  + "cool\" you say to yourself.\n\n"
				  + "Press U to Undress and return to the closet or S to climb the Stairs.";
		
		if (Input.GetKeyDown(KeyCode.U)) {
			myState = States.in_closet;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.courtyard;
		}
	}
	
	void stateCourtyard() {
		text.text = "You grab the mop and walk up to the courtyard.  As you walk a guard dog sniffs your leg, can he "
				  + "smell your fear?  You maintain your gate and slip into the shadows.  You turn around to see the "
				  + "reactions.  There are none, they bought it.  You waste no time to escape.\n\n"
				  + "Press P to Play again.";
		
		if (Input.GetKeyDown(KeyCode.P)) {
			myState = States.cell;
		}
	}
}
