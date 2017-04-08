using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter1
{
	public class Detaction : MonoBehaviour
	{

		private RaycastHit hit;
		private LayerMask detectionLayer;
		private float checkRate = 0.5f;
		private float range = 5;
		private float nextCheck;
		private Transform myTranform;

		// Use this for initialization
		void Start ()
		{
			setInitailReference ();
		}

		void setInitailReference ()
		{
			myTranform = transform;
			detectionLayer = 1 << 9;
		}
	
		// Update is called once per frame
		void Update ()
		{
			DetectItem ();
				
		}

		void DetectItem ()
		{
		
			if (Time.time > nextCheck) {
				nextCheck = Time.time + checkRate;
				if (Physics.Raycast (myTranform.position, myTranform.forward,	out hit, range, detectionLayer)) {
					Debug.Log (hit.transform.name + "is an item");	
				}
			}
		}
	}
}
