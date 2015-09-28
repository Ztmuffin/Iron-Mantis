using UnityEngine;
using System.Collections;

public class LoopsPractice2 : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		string[] strings = new string [3];

		strings[0] = "Who are you?";
		strings[1] = "Bond";
		strings[2] = "James Bond!";

		foreach (string Bill in strings)
		{
			print (Bill);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void Func(string str)
	{
	
	}
}
