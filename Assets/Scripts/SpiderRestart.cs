using UnityEngine;
using System.Collections;

public class SpiderRestart : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Application.LoadLevel (Application.loadedLevel);
			//Destroy (gameObject);
		}
	}
}
