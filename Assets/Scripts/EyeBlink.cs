using UnityEngine;
using System.Collections;

public class EyeBlink : MonoBehaviour {

	private SpriteRenderer catEye;
		
	void Start()
	{
		catEye = GetComponent<SpriteRenderer>();
		InvokeRepeating("Blink", 1.8f, 1.8f);
	}

	void Blink()
	{
		catEye.enabled = !catEye.enabled;
	}

}
