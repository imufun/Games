using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter1
{
	public class WalkThroughWalk : MonoBehaviour
	{

		void OnEnable(){
			gameObject.layer = LayerMask.NameToLayer ("NotSolid");		
		}
		void OnDisable(){
			gameObject.layer = LayerMask.NameToLayer ("Default");
		}
	}
}
