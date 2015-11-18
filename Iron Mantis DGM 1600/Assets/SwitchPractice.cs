using UnityEngine;
using System.Collections;

public class SwitchPractice : MonoBehaviour 
{
 
	public enum Dificulty {Beginner, Normal, Hard, Expert};
	
	public Dificulty myDificulty;
	
	void DamageRecieved()
	{
		switch (myDificulty)
		{
		 case Dificulty.Beginner:
		 	print("you only recieve 1 damage for every hit");
		 	break;
		 case Dificulty.Normal:
		 	print("you only recieve 2 damage for every hit");
		 	break;
		 case Dificulty.Hard:
		 	print("you will recieve 3 damage for every hit");
		 	break;
		 case Dificulty.Expert:
		 	print("you will recieve 4 damage for every hit");
		 	break;
		 default:
		 	print("there is insufficient data");
		 	break;
		}
	}
	void Update()
	{
		DamageRecieved ();
	}
}	


