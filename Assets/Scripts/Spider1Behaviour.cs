using UnityEngine;
using System.Collections;

public class Spider1Behaviour : MonoBehaviour {
	
	public float spiderSpeed = 0.01f;
	public float spiderSlowSpeed = 0.005f;
	
	void FixedUpdate () 
	{
		if (transform.position.x == -2f && transform.position.y <= 20f && transform.position.y >= 16f)
			transform.position = new Vector2 (transform.position.x, transform.position.y - 1 * spiderSpeed);
		
		if (transform.position.y > 15f && transform.position.y < 16f)
			transform.position = new Vector2 (-2.005f, transform.position.y);
		
		if (transform.position.x == -2.005f && transform.position.y > 15f && transform.position.y <= 20f)
			transform.position = new Vector2 (transform.position.x, transform.position.y + 1 * spiderSlowSpeed);
		
		if (transform.position.x == -2.005f && transform.position.y > 20f)
			transform.position = new Vector2 (-2f, 20f);
	}

}