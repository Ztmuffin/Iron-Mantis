using UnityEngine;
using System.Collections;

public class LoopsPractice : MonoBehaviour 
{
	int Coinsinthepouch = 5;
		void Start ()
	{
		while (Coinsinthepouch < 14) 
		{
			Debug.Log ("you picked up a Coin");
			Coinsinthepouch++;
		}
	}
}