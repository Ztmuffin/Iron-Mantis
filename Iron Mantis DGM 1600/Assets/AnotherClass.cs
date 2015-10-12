using UnityEngine;
using System.Collections;

public class AnotherClass : MonoBehaviour
{
	public int phones;
	public int tablets;
	
	private int earbuds;
	private int glass;
	
	public void Purchase (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("Items you can purchase: " + answer);
	}
	
	private void FreeStuff (int a, int b)
	{
		int answer;
		answer = a + b;
		Debug.Log("What you can get for free: " + answer);
	}
}
