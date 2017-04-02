using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Chapter1
{
	public class Welcome : MonoBehaviour
	{

		public string myMessage = "Welcome";
		private Text textWelcome;
		public GameObject canvasWelcome;
		public float waitTime = 3.5f;

		// Use this for initialization
		void Start ()
		{
			setInitialMessage ();
			MyWelcomeMessage ();
		}
	
		// Update is called once per frame
		void Update ()
		{
		
		}

		void  setInitialMessage ()
		{
		
			textWelcome = GameObject.Find ("TextWelcome").GetComponent<Text> ();
		}

		void MyWelcomeMessage ()
		{
			if (textWelcome != null) {
				textWelcome.text = myMessage;
			} else {
				Debug.LogWarning ("welcome Text not assigned.");
			}
			StartCoroutine(DisableCanvas(3.5f));
		}

		IEnumerator DisableCanvas(float waitTime){
			yield return new WaitForSeconds (waitTime);
			canvasWelcome.SetActive (false);
		}
	}
}
