using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour {

	public float topSpeed = 10f;
	bool facingRight = true;


	Animator anim;


	void Start(){
	
		anim = GetComponent<Animator>();
	}


	void FixedUpdate(){

		float move = Input.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * topSpeed, GetComponent<Rigidbody2D>().velocity.y);


		anim.SetFloat ("Speed", Mathf.Abs(move));
		//if we are the negatuve direction and not faceing right
		if (move > 0 && !facingRight)
			Filp ();
		else if (move < 0 && facingRight)
			Filp ();
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
