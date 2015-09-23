using UnityEngine;
using System.Collections;

public class Ifstatements : MonoBehaviour 
{
	float ChocholateTemperature = 85.0f;
	float hotLimitTemperature = 70.0f;
	float coldLimitTemperature = 40.0f;
	
	
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();
		
		ChocholateTemperature -= Time.deltaTime * 5f;
	}
	
	
	void TemperatureTest ()
	{
		// If the Chocholate's temperature is greater than the hottest drinking temperature...
		if(ChocholateTemperature > hotLimitTemperature)
		{
			// ... do this.
			print("Chocolate is too hot.");
		}
		// If it isn't, but the chocholate temperature is less than the coldest drinking temperature...
		else if(ChocholateTemperature < coldLimitTemperature)
		{
			// ... do this.
			print("Chocholate is too cold.");
		}
		// If it is neither of those then...
		else
		{
			// ... do this.
			print("Chocholate is just right.");
		}
	}
}