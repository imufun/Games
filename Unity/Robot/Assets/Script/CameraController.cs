using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;

	Vector3 velocity  = Vector3.zero;
	 
	public float smothTime = .15f;

	void FixedUpdate (){
		
		// target postion
		Vector3 targetPos = target.position;

		//align the camra add the target z position
		targetPos.z = transform.position.z;

		transform.position = Vector3.SmoothDamp (transform.position, targetPos, ref velocity, smothTime);

	}
}
