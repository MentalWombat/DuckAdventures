using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour {
	
	public float fadeSpeed = 4.5f;
	public RawImage fadingScreen;
	private bool sceneStarting = true;
	
	void Awake()
	{
		GetComponent<RawImage>().uvRect = new Rect(0f, 0f, Screen.width, Screen.height);
		GetComponent<RectTransform> ().sizeDelta = new Vector2 (Screen.width, Screen.height);
	}
	
	void Update()
	{
		if (sceneStarting) 
		{
			StartCoroutine("StartScene");
		}
	}
	
	void FadeToClear()
	{
		fadingScreen.color = Color.Lerp (fadingScreen.color, Color.clear, fadeSpeed * Time.deltaTime);
	}
	
	void FadeToBlack()
	{
		fadingScreen.color = Color.Lerp (fadingScreen.color, Color.black, fadeSpeed * Time.deltaTime);
	}
	
	IEnumerator StartScene()
	{
		FadeToClear ();
		yield return null;

		if (fadingScreen.color.a <= 0.05f) 
		{
			fadingScreen.color = Color.clear;
			fadingScreen.enabled = false;
			sceneStarting = false;
		}
	}

	public void EndScene()
	{
		StartCoroutine("CoEndScene");
	}

	public IEnumerator CoEndScene()
	{
		fadingScreen.enabled = true;
		FadeToBlack ();
		yield return null;
		
		if (fadingScreen.color.a >= 0.95f) 
		{
			Application.LoadLevel(Application.loadedLevel + 1);
		}
	}

}
