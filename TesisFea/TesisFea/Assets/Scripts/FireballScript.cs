using UnityEngine;
using System.Collections;

public class FireballScript : MonoBehaviour {
	HUDScript hud;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			hud = GameObject.Find("Main Camera").GetComponent<HUDScript>();
			hud.IncreaseScore(10);
			Destroy (this.gameObject);
			Application.LoadLevel(1);
			//Debug.Break ();
			return;
		}
	}
}
