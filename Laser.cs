using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {


	Rigidbody rb;

	public float forceAMT;










	// Use this for initialization
	void Start () {

		rb = GetComponent <Rigidbody>();





	}
	
	// Update is called once per frame
	void Update () {


		// crates a line based on the position of the mouse on the screen.
		Ray laser = Camera.main.ScreenPointToRay (Input.mousePosition);

		RaycastHit hit = new RaycastHit ();

		// raycast parameters are (the ray, stored information, how far ray will travel.)
		if(Physics.Raycast(laser, out hit, 10000f)){

			Debug.Log ("you shot me!");


		}

		if(Physics.Raycast(laser,out hit, 10000f)){

			rb.AddForce (new Vector3(0f,1f,0f) * forceAMT);


		}




	}
}
