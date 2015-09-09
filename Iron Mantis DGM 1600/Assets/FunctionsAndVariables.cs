using UnityEngine;
using System.Collections;

public class FunctionsAndVariables : MonoBehaviour 
{
	int myInt = 6;

	void Start ()
	{
		myInt = MultiplyByThree (myInt);
	 Debug.Log (myInt);
	}

	int MultiplyByThree (int number)
	{
		int ret;
		ret = number * 3;
		return ret;
	}
	
}
