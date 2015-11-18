using UnityEngine;
using System.Collections;

public class DuckSpawner : MonoBehaviour 
{
	public GameObject duck;
	// Use this for initiaoklization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () 
	public void SpawnDuck()
	{
		Debug.Log("Spawn Duck");
		Instantiate(duck, transform.position, Quaternion.identity);
	}
}
