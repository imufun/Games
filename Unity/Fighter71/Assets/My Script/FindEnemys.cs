using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter1{
public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	GameObject[] enemies;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SearchForEnemies(){
		enemies = GameObject.FindGameObjectsWithTag ("Enemy");
		if (enemies.Length>0) {
			foreach(GameObject go in enemies){				
				Debug.Log (go.name);
				go.SetActive (false);
			}
		}
	}
}
}