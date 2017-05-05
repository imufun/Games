using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 10.0f;
	private Rigidbody rb;
 
	void Start(){
	
		rb = GetComponent<Rigidbody>();

	}

	void FixedUpdate(){
		float moveHoraizantal = Input.GetAxis ("Horizontal");
		float	 moveVertical = Input.GetAxis ("Vertical");
		Vector3 Movement = new Vector3 (moveHoraizantal,0.0f, moveVertical);

		rb.AddForce (Movement * speed);
	}
}
