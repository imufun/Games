using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter1
{
	public class GrenedExplotion : MonoBehaviour
	{

		private Collider[] hitColliders;
		public float blastRadius;

		void OnCollisionEnter(Collision col){
			//Debug.Log (col.contacts[0].point.ToString());
			ExplotionWork(col.contacts[0].point);

			Destroy (gameObject);
		}

		void ExplotionWork(Vector3 explotionPoint){
			hitColliders = Physics.OverlapSphere (explotionPoint, blastRadius);

			foreach(Collider hitCol in hitColliders){
				Debug.Log (hitCol.gameObject.name);
			}
		}
	}
}
