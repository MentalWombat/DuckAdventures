using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExitLevel : MonoBehaviour {

	public FadeInOut fadeInOut;

	void Start()
	{
		GameObject pan = GameObject.Find ("FadingScreen");
		fadeInOut = pan.GetComponent<FadeInOut> ();
	}

	void OnCollisionStay2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player") 
		{
			fadeInOut.EndScene();
			//Application.LoadLevel (Application.loadedLevel + 1);
		}
	}

}
