using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

	void Start () {
		score = PlayerPrefs.GetInt ("Score");
	}
	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");

		GUI.Label (new Rect (Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);
		if (GUI.Button(new Rect(Screen.width / 2 -30, 350, (Screen.width/4) , (Screen.height/3)), "Retry?¿"))
		{
			Application.LoadLevel(0);
		}
		/*if (GUI.Button(new Rect(Screen.width / 2 -30, 350, 100 , 60), "Retry?¿"))
		{
			Application.LoadLevel(0);
		}*/

	}

}
