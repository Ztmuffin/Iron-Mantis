using UnityEngine;
using System.Collections;

public class GUImanager : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
	 	GameManager.OnSpawnDucks = ResetBullets;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	public void DisableBullet (int index)
	{
		bullets[index].SetActive(false);
	}
	void ResetBullets ()
	{
		foreach(GameObject bul in ResetBullets)
		{
			bul.SetActive(true);
		}
	}
}
