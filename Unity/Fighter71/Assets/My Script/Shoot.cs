using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	private float FireRate = 3.5f;
	private float nextFire;

	private RaycastHit hit;
	private float range = 300;
	private Transform myTransform;
	// Use this for initialization
	void Start () {
		setInitialReference ();
	}
	
	// Update is called once per frame
	void Update () {
		checkShoot ();
	}


	void setInitialReference(){
		myTransform = transform;	
	}
	void checkShoot(){

		// One method input

		//if (Input.GetKey(KeyCode.Mouse0) && Time.time> FireRate) {
		//	nextFire = Time.time + FireRate;
		//	Debug.Log ("pressed" + "fire " + nextFire);
		//} else {
		//	Debug.Log ("Not pressed");
		//}

		// other method input
		//if (Input.GetButton("Fire1") && Time.time> FireRate) 
		//{
		//	Debug.DrawRay (transform.position,transform.forward, Color.green, 3); 	 
		//	if (Physics.Raycast (transform.position, transform.forward, out hit, range)) 
		//	{
		//		Debug.Log (hit.transform.name);
		//	}

			//Debug.Log ("Not pressed");

		//}


		// Effecient method
		if (Input.GetButton("Fire1") && Time.time> FireRate) 
		{
			Debug.DrawRay (myTransform.TransformPoint(0,0,1),myTransform.forward, Color.green, 3); 	 
			if (Physics.Raycast (myTransform.TransformPoint(0,0,1), myTransform.forward, out hit, range)) 
			{
				if (hit.transform.CompareTag ("Enemy")) {
					Debug.Log ("Enemy" + hit.transform.name);
				} else {
					Debug.Log ("NO Enemy there");
				}
					

			}

			//Debug.Log ("Not pressed");

		}

		// We can use any one method use our game;
	}
}
