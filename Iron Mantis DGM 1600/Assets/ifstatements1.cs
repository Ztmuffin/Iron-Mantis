using UnityEngine;
using System.Collections;

public class ifstatements1 : MonoBehaviour 
{
	private float HowHigh = 3f;	
	private float TooHigh = 5f;

	void Update () 
	{
		if (transform.position.y <= HowHigh)

		{
			print("Incomming!");
		}
		else if(transform.position.y >= TooHigh)
		{
			print("I'm flying!");
		}
		else 
		{
			print("I'm getting closer");
		}
	}
}