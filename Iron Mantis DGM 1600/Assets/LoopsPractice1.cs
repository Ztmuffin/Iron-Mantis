using UnityEngine;
using System.Collections;

public class LoopsPractice1 : MonoBehaviour 
{
	int bananasonthetree =5;

	// for loop
	void Start () 
	{
		for(int i = 1; i < bananasonthetree; i++)
		{
			Debug.Log ("This is how many bananas are on the tree: "+i);
		
		}
		 
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
