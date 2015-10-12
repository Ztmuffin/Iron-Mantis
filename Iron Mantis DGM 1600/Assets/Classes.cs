using UnityEngine;
using System.Collections;

public class Classes : MonoBehaviour 
{
	public class Cat
	{
	public int age;
	public Color hairColor;
	
	public Cat()
		{
			age = 0;
			hairColor = Color.black;
		}
	
	public Cat(int _age, Color _hair)
		{
			age = _age;
			hairColor = _hair;
		}
	}
	void Start () 
		{
		 // Cat fluffy = new Cat(12,Color.gray);
		 int num1 = 5;
		 int num2 = num1;
		 num2 = 100;
		 
		Cat fluffy = new Cat(12,Color.gray);
		Cat charlie = fluffy;
		charlie.hairColor = Color.green;
		
		Debug.Log ("num1 "+ num1);
		Debug.Log ("num2 "+ num2);
		}
	
	void Update () {
	
	}
}
