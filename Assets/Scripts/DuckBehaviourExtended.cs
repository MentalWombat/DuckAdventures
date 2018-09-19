using UnityEngine;
using System.Collections;

public class DuckBehaviourExtended : MonoBehaviour {
	
	public float maxSpeed = 10f;
	public float jumpForce = 700f;
	public float move;
	bool facingLeft = true;
	
	public Transform groundCheck;
	public float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	bool grounded;


	void Start () 
	{
		Cursor.visible = false;
	}
	
	void FixedUpdate ()
	{
		move = Input.GetAxis ("Horizontal");
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
	}
	
	void Update () 
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		if (facingLeft && move > 0)
			Flip ();
		else if (move < 0 && !facingLeft)
			Flip ();
		
		if (Input.GetKeyDown (KeyCode.UpArrow) && grounded)
			GetComponent<Rigidbody2D>().AddForce (new Vector2 (0f, jumpForce));
	}
	
	void Flip ()
	{
		facingLeft = !facingLeft;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "berry") 
		{
			Object.Destroy(other.gameObject);

			//make the duck grow x0.2
			Vector3 theScaleX = transform.localScale;
			theScaleX.x *= 1.2f;
			transform.localScale = theScaleX;

			Vector3 theScaleY = transform.localScale;
			theScaleY.y *= 1.2f;
			transform.localScale = theScaleY;

			//make the camera go down in order to be centered on duck when duck grows
			Vector3 cameraY = Camera.main.transform.localPosition;
			cameraY.y -= 1.2f;
			Camera.main.transform.localPosition = cameraY;

			//make the duck jump higher and move quicker
			jumpForce += 150f;
			maxSpeed += 2f;

			//change size of the camera
			//Camera.main.orthographicSize += 0.5f;
		}

		if (other.gameObject.tag == "apple") 
		{
			Object.Destroy(other.gameObject);
			
			//make the duck jump higher and move quicker
			jumpForce += 300f;
			maxSpeed += 3f;
		}
	}
	
}