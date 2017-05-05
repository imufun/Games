using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZMObjects : MonoBehaviour {


	[SerializeField] private float ObjectSpeed = 1;
	[SerializeField] private float resetPositon = -100f;
	[SerializeField] private float startPosition = 47f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		transform.Translate (Vector3.left * ( ObjectSpeed * Time.deltaTime));
		if (transform.localPosition.x <= resetPositon) {
			Vector3 newPos = new Vector3 (startPosition,transform.position.y, transform.position.z);
			transform.position = newPos;
		}
	}
}
