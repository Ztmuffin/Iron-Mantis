using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour 

	{
		public int alpha = 3;
		
		private int beta = 5;
		private int charlie = 0;
		
		private AnotherClass myOtherClass;
		void Start()
		{
			alpha = 81;
			
			myOtherClass =new AnotherClass();
			myOtherClass.Purchase (alpha, myOtherClass.phones);
		}	
		
		void example (int shoes, int socks)
		{
			int answer;
			answer = shoes * socks * alpha;
			Debug.Log (answer);
		}
		
		void Update () 
		{
			Debug.Log("I am " + alpha);
		}
		
	}