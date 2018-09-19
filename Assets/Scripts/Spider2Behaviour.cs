using UnityEngine;
using System.Collections;

public class Spider2Behaviour : MonoBehaviour {

	public float spiderSpeed = 0.01f;
	public float spiderSlowSpeed = 0.005f;

	void FixedUpdate () 
	{
		if (transform.position.x == 4f && transform.position.y <= 20f && transform.position.y >= 8f)
			transform.position = new Vector2 (transform.position.x, transform.position.y - 1 * spiderSpeed);

		if (transform.position.y > 7f && transform.position.y < 8f)
			transform.position = new Vector2 (4.005f, transform.position.y);

		if (transform.position.x == 4.005f && transform.position.y > 7f && transform.position.y <= 20f)
			transform.position = new Vector2 (transform.position.x, transform.position.y + 1 * spiderSlowSpeed);

		if (transform.position.x == 4.005f && transform.position.y > 20f)
			transform.position = new Vector2 (4f, 20f);
	}

}