using UnityEngine;
using System.Collections;


public class LoadOnClick : MonoBehaviour {

	void Start () 
	{
		Cursor.visible = true;
	}

	public void LoadScene(int level)
	{
		Application.LoadLevel (level);
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}
