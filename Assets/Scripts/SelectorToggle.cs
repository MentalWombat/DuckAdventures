using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectorToggle : MonoBehaviour {
	
	public Image duckSelector;
	
	// Use this for initialization
	void Start () 
	{
		duckSelector = GetComponent<Image>();
	}
	
	public void DuckOn ()
	{
		duckSelector.color = Color.white;
	}

	public void DuckOff ()
	{
		duckSelector.color = Color.clear;
	}

}
