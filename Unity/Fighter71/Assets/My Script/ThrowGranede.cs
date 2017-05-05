using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
	public class ThrowGranede : MonoBehaviour
	{

		public GameObject GrenadPrefab;
		public Transform myTransform;
		public float propuisionForce;

		// Use this for initialization
		void Start ()
		{
			SetInitalReference ();
		}
	
		// Update is called once per frame
		void Update ()
		{
		
			if(Input.GetButtonDown("Fire1")){
				SpwanGrenede();
			}
		}

		void SetInitalReference(){
			myTransform = transform; 
		}
		void SpwanGrenede(){
			GameObject go=  (GameObject)Instantiate(GrenadPrefab, myTransform.TransformPoint(0,0,0.5f),myTransform.rotation);
			go.GetComponent<Rigidbody> ().AddForce (myTransform.forward * propuisionForce, ForceMode.Impulse);
			Destroy(go,10);
		}
	}
}
