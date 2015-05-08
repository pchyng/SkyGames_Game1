using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {

	float playerScore = 0 ;
	float playerDistance = 0;
	
	// Update is called once per frame
	void Update () {

		playerDistance += Time.deltaTime;

	}
	public	void IncreaseScore (int amount)
	{
		playerScore += amount;
	}
	void OnDisable()
	{
		//dontdetroyonload cambiar esto por esto
		PlayerPrefs.SetInt ("Distance", (int)(playerDistance * 100));
		PlayerPrefs.SetInt ("Coins", (int)(playerScore));


	}
	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 100, 30), "Distance: " + (int)(playerDistance*100));
		GUI.Label (new Rect (10, 20, 100, 30), "Coins: " + (int)(playerScore));

	}
}
