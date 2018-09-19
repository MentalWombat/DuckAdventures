using UnityEngine;
using System.Collections;

public class SpiderBehaviour : MonoBehaviour {
	
	public float spiderSpeed = 0.01f;
	public float spiderSlowSpeed = 0.005f;

	void FixedUpdate () 
	{
		StartCoroutine ("Crawl");
	}

	IEnumerator Crawl()
	{
		yield return new WaitForSeconds (3);

		if (transform.position.x == -8f && transform.position.y <= 20f && transform.position.y >= 10f)
			transform.position = new Vector2 (transform.position.x, transform.position.y - 1 * spiderSpeed);
		
		if (transform.position.y > 9f && transform.position.y < 10f)
			transform.position = new Vector2 (-8.005f, transform.position.y);
		
		if (transform.position.x == -8.005f && transform.position.y > 9f && transform.position.y <= 20f)
			transform.position = new Vector2 (transform.position.x, transform.position.y + 1 * spiderSlowSpeed);
		
		if (transform.position.x == -8.005f && transform.position.y > 20f)
			transform.position = new Vector2 (-8f, 20f);
	}

}