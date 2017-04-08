using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
	public class TriggerExample : MonoBehaviour
	{
 
		void OnTriggerEnter(Collider other){
			Debug.Log (other.name + "has enter") ;
		}

		void OnTriggerExit(Collider other){
			Debug.Log (other.name + "has exited" );
		}
		void OnTriggerStay(Collider other){
			Debug.Log (other.name + "is int the trigger");
		}
	}
}