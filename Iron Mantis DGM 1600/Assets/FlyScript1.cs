using UnityEngine;
using System.Collections;

public class FlyScript1 : MonoBehaviour 
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
		else if(transform.position.y >= heightTest)
		{
			Debug.Log("I'm flying!");
		}
	}
	//Hello
	//One liner tests
		private void FlyAway()
	{
		Debug.Log ("Fly Away!");
		Vector3 newPosition = new Vector3(0,7,0);
		transform.position = newPosition;
	}
	/*Multiple
	 * line
	 * notes
	 * are
	 * great*/

}