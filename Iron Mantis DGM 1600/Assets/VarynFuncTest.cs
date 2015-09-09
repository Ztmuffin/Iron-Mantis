using UnityEngine;
using System.Collections;

public class VarynFuncTest : MonoBehaviour {

	int myInt = 49;
	void Start ()
	{
		myInt = MultiplyByTwo (myInt);
		Debug.Log (myInt);
	}
	int MultiplyByTwo (int number){
	
		int ret;
		ret = number * 2;
		return ret;
	}


}