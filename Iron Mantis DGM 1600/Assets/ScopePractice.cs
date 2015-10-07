using UnityEngine;
using System.Collections;

public class ScopePractice : MonoBehaviour 
{
/*The following 3 int's are in the scope of the class "Scope Practice".
(defined by the curly braces) {} */
	public int joe = 10;
	
	private int sue = 0;
	private int john = 5;
	
	private AnotherClass myOtherClass;
	
	void Start ()
	{
		joe = 24;
		
		myOtherClass = new AnotherClass();
		myOtherClass.FruitMachine(joe, myOtherClass.apples);
	}
	// This will be the example
	// any variables in here are not in scope with the class "Scope Practice".
	void Example(int home, int work)
	{
		int answer;
		answer= home * work * joe;
		Debug.Log (answer);
	}
	
	void Update () 
	{
		Debug.Log ("Joe is"+joe+"years old");
	}
}
