using UnityEngine;
using System.Collections;

public class SpamScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public bool spawnRam = false;

	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	// Update is called once per frame
	void Spawn () 
	{

		Vector3 vectTest = transform.position;
		if (spawnRam) 
			vectTest.y = (Random.Range (-328,328))/100;
		Instantiate (obj [Random.Range (0, obj.Length)], vectTest, Quaternion.identity);
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}
