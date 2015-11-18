using UnityEngine;
using System.Collections;

public class DuckMovement : MonoBehaviour {
	public float speed;
	public Vector3 direction;

	// Use this for initialization
	void Start () 
	{
		DirectionChanger ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		transform.position = transform.position + (direction * speed);
	}

	public void DirectionChanger ()
	{
		direction = new Vector3 (Random.Range (-1,1), Random.Range(-.2f, 1f), 0);
	}
}
