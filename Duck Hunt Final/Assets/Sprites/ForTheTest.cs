//Instructions, Identify and explain each line in this script using comments.

using UnityEngine;
using System.Collections;

//public is the type of function easily accessable from other functions and classes
// MidTerm is the name of the class
public class MidTerm : MonoBehaviour {
	// int myInt is a variable (it can be any number you want
	public int myInt = 6;
	//float is a unit of measurement (in this case tempurature)
	float coffeeTemperature = 85.0f;
	// these public and private floats are defining a range of tempuratures
	private float hotLimitTemperature = 70.0f;
	public float coldLimitTemperature = 40.0f;
	// int is a variable which in this case is called numEnimies, there are 3 of them
	int numEnemies = 3;
	//private makes these variables only accessable from this very function in this very class and not from anywhere else
	// additionally MidTerm is a function and GameObject is an Array
	private MidTerm myMidterm;
	public GameObject[] players;
	
	// void means this function will not return anything  Start is what is run at the start of the game.
	void Start ()
	{
	// this is the name of the function we are running
		TemperatureTest();
		Debug.Log (myInt);
		// a loop, for every scenario (whenever i happens to equal 0) there is a set outcome (one enimy is added to the playing field).
		// in this case whenever i is 0 an enimy is added
		for(int i = 0; i < numEnemies; i++)
		{
		// this prints a text saying what was done (which happens to equal the same number as i
			Debug.Log("Creating enemy number: " + i);
		}
		//the name of another function we are running
		myMidterm = GetComponent<MidTerm>();
		// another loop but this time it is showing us what each of the players name's are
		// for every time i is equal to 0 and is still less than the players length  i increases by one
		for(int i = 0; i < players.Length; i++)
		{
			Debug.Log("Player Number "+i+" is named "+players[i].name);
		}
		// this is an Enumeration called my direction
		Direction myDirection;
		// the function is called myDirection
		myDirection = Direction.North;
		// this is putting(passing) the function myDirection into ReverseDirection
		ReverseDirection (myDirection);
		
	}
	// void update is updated and run consistantly through the game
	void Update ()
	{
	// If the spacebar is pressed the funcion tempurature test will run
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		// the tempuratrue of the coffee goes down with time. Exponentially 
		coffeeTemperature -= Time.deltaTime * 5f;
	}
	
	void TemperatureTest ()
	{
	// if statement printing "coffee is too hot" if the tempurature is over a certain metric
		string tooHot = "Coffee is too hot.";
		if(coffeeTemperature > hotLimitTemperature)
		{
			print(tooHot);
		}
	}
	// an enumeration stating the constant directions
	enum Direction{North, East, South, West};
	// running the funtion that earlier mentioned makes myDirection the opposite
	//by...  changing the variable dir.  in this case from Direction.North to Direction.South
	void ReverseDirection (Direction dir)
	{
		if(dir == Direction.North)
			dir = Direction.South;
		
		
	}
	// This is a greeting function  meaning based on the player's intelegence they will respond accordingly
	// in this there are set 5 cases, or levels of intellegence, a charachter may have.
	void Greet()
	{
		switch (myInt)
		{
		// this is for the smartest of the bunch, or in this case we will print the following:
		case 5:
			print ("Why hello there good sir! Let me teach you about Trigonometry!");
			break;
			// this next case is for fairly smart people, or if they don't fall into catagory 5,3,2,or 1
		case 4:
			print ("Hello and good day!");
			break;
			// this one is for average people etc
		case 3:
			print ("Whadya want?");
			break;
			// this isnt very comprehensable
		case 2:
			print ("Grog SMASH!");
			break;
			//why does Grog want to smash?
		case 1:
			print ("Ulg, glib, Pblblblblb");
			break;
			// i cannot understand you
		default:
		// for those so unintelegent they don't have anything to say
			print ("Incorrect intelligence level.");
			break;
		}
	}
}