using UnityEngine;
using System.Collections;

public class ScopePractice : MonoBehaviour 
{
	public int oranges = 3;
	
	public int tomatoes = 14;
	private int carrots = 2;
	
	private AnotherClass myotherclass = new AnotherClass();
	void Start ()
	{
	myotherclass.Purchase(oranges, carrots);
	}
	void Example (int _wall, int _floor)
	{
		int answer;
		answer = _wall * _floor * oranges;
		Debug.Log(answer);
	}
	void Update()
		{
			Debug.Log("There are "+oranges + " oranges");
		}
}
