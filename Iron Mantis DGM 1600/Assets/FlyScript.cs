using UnityEngine;
using System.Collections;

public class FlyScript : MonoBehaviour 
{
	private float heightTest = 3f;
	void Start ()
	{
		Debug.Log (transform.position.y);
		if (transform.position.y <= heightTest) 
		{
			Debug.Log ("I'm about to hit the ground!");
			FlyAway ();
		} 
		else if (transform.position.y >= heightTest) 
		{
			Debug.Log ("I'm flying!");
		}
	}
	//hello
//anything on this line is a comment. but if i press enter no more comments
		private void FlyAway()
	{
		Debug.Log("Fly Away!");
		Vector3 newPosition = new Vector3(0,7,0);
		transform.position = newPosition;
	}
	/*this
	 * is 
	 * multiple lines
	 * */
}