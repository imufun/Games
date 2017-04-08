using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter1
{
	public class TriggerExample : MonoBehaviour
	{
 
		private WalkThroughWalk walkThroughWallScript;

		void Start(){
			SetInitialReference ();
		}
		 


		void OnTriggerEnter (Collider other)
		{
			//Debug.Log (other.name + "has enter") ;

			walkThroughWallScript.SetLayerToNotSolid ();
			 
		}

		void OnTriggerExit (Collider other)
		{
			//Debug.Log (other.name + "has exited" );
			walkThroughWallScript.SetLayerToDefault();

		}

		//void OnTriggerStay (Collider other)
		//{
			//Debug.Log (other.name + "is int the trigger");
		//}


		void SetInitialReference ()
		{
			if (GameObject.Find ("Wall") != null) {

				walkThroughWallScript = GameObject.Find ("Wall").GetComponent<WalkThroughWalk> ();
			}
		}



	}
}