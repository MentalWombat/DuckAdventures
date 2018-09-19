using UnityEngine;
using System.Collections;

public class DuckBehaviour : MonoBehaviour {

	public float maxSpeed = 10f;
	public float jumpForce = 900f;
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

}