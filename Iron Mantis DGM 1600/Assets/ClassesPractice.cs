using UnityEngine;
using System.Collections;

public class ClassesPractice : MonoBehaviour 
{
	public class Potions
	 {
		 public int potionPotency;
		 public Color potionColor;
		 
		 public Potions ()
		 {
			 potionPotency = 0;
			 potionColor = Color.black;
		 }
		 public Potions (int _pot, Color _col)
		 {
			potionPotency = _pot;
			potionColor = _col;
		 
		}	 
	}
	// Use this for initialization
	void Start () 
{
		int num1 = 4;
		int num2 = num1;
		
		
		Potions greenPotion = new Potions(5,Color.green);
		Potions bluePotion = new Potions (9,Color.cyan);
		Potions yellowPotion = greenPotion;
		
		Debug.Log ("greenpotion potency: " + greenPotion.potionColor);
		Debug.Log ("bluepotion potency: " + bluePotion.potionColor);
		
	}
}