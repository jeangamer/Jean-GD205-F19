using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PhysicsMove : MonoBehaviour {

	Rigidbody rb;

	public float forceAMT;
	public GameObject player;


	void Start () {


		rb = GetComponent <Rigidbody>();




	}
	
	// Update is called once per frame
	void FixedUpdate () {


			//move forward
		if(Input.GetKey(KeyCode.W)){

			rb.AddForce (new Vector3(0f,0f,1f)*forceAMT);
		}
		//move left
		if(Input.GetKey(KeyCode.A)){

			rb.AddForce (new Vector3(-1f,0f,0f)*forceAMT);
		}
		//move backward
		if(Input.GetKey(KeyCode.S)){

			rb.AddForce (new Vector3(0f,0f,-1f)*forceAMT);
		}

		//move right
		if(Input.GetKey(KeyCode.D)){

			rb.AddForce (new Vector3(1f,0f,0f)*forceAMT);
		}


		//move up(Jump)
		if(Input.GetKey(KeyCode.Space)){

			rb.AddForce (new Vector3(0f,1f,0f)*forceAMT);
		}
			
	




	}//void update bottom






	//destroy pickup if player touches it.
	void OnTriggerEnter(Collider other){

		if(other.gameObject.CompareTag("Pick Up")){


			other.gameObject.SetActive (false);


	}






}
}