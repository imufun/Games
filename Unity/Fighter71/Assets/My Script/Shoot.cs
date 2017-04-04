using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	private float FireRate = 3.5f;
	private float nextFire;

	private RaycastHit hit;
	private float range = 300;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		checkShoot ();
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

		if (Input.GetButton("Fire1") && Time.time> FireRate) {
			nextFire = Time.time + FireRate;
			Debug.Log ("pressed" + "fire " + nextFire);
		} else {

			if (Physics.Raycast (transform.position, transform.forward, out hit, range)) {
				Debug.Log (hit.transform.name);
			}
			//Debug.Log ("Not pressed");

		}
	}
}
