using UnityEngine;
using System.Collections;

public class enumerations : MonoBehaviour 
{
	enum Dificulty: short {easy=5, medium, hard, expert};

	void Start()
	{
		Dificulty setDificulty;
		setDificulty = Dificulty.easy;
		
		setDificulty = OppositeDificulty (setDificulty) ;
	}
	
	Dificulty OppositeDificulty (Dificulty dif)
	{
	
	dif = Dificulty.expert;
	
	return dif;
	}


}