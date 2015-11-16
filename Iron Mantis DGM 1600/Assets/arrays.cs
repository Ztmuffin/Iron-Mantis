using UnityEngine;
using System.Collections;

public class arrays : MonoBehaviour 
{
public GameObject[] somethingElse;

	// Update is called once per frame
	void Start () 
	{
		somethingElse = GameObject.FindGameObjectsWithTag ("sphere");
		for (int i=0; i<somethingElse.Length; i++)
		{
		Debug.Log("There are " +i+ " spheres");
		} 
	}
}