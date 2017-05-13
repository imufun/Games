using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour {

	public float topSpeed = 10f;
	bool facingRight = true;


	Animator anim;

	bool Grounded = false;

	public Transform groundCheck;

	//
	float groundRadis = 0.2f;

	public float jumpForce = 700f;


	public LayerMask whatIsGroud;


	bool doubleJump = false;

	void Start(){
	
		anim = GetComponent<Animator>();
	}


	void FixedUpdate(){

		Grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadis, whatIsGroud);

		anim.SetBool ("Ground",Grounded);

		// double jump check
		if (Grounded)
			doubleJump = false;

		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		float move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * topSpeed, GetComponent<Rigidbody2D>().velocity.y);


		anim.SetFloat ("Speed", Mathf.Abs(move));
		//if we are the negatuve direction and not faceing right
		if (move > 0 && !facingRight)
			Filp ();
		else if (move < 0 && facingRight)
			Filp ();
	}

	void Update(){
		if((Grounded || !doubleJump) && Input.GetKeyDown(KeyCode.Space)){
			anim.SetBool ("Ground", false);
			GetComponent<Rigidbody2D> ().AddForce (new Vector2(0, jumpForce));

			if (!doubleJump && !Grounded)
				doubleJump = true;
		}
	}

	void Filp(){
		// saying we are facng the oposition directions
		facingRight = !facingRight;

		//get the local scale
		Vector3 theScale = transform.localScale;

		//flip on z scale
		theScale.x = -1;
		transform.localScale = theScale;
	}

}
