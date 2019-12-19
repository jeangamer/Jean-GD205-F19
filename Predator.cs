using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Predator : MonoBehaviour {


	Rigidbody rb;

	public Transform target;

	public float ForceAMT;





	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();


	}
	
	// Update is called once per frame
	void Update () {



		//take the position of the target(Player) and the position of the predator and subtact it.(in other words)

		Vector3 targetDir = Vector3.Normalize (target.position - transform.position);


		rb.AddForce (targetDir * ForceAMT);





	}


	void OnCollisionEnter(Collision colReport){

		if(colReport.gameObject.CompareTag("Player")){

			Destroy(colReport.gameObject);



		}
			






	}









}
