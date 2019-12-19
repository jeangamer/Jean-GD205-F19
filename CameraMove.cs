using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public GameObject Player;

	private Vector3 Offset;






	void Start () {


		// subtract the diffrence in position between the camera and the player.
		Offset = transform.position - Player.transform.position;




	}








	// LateUpdate is garanteed to run after all items have ben processed in update.
	void LateUpdate () {



		//keeps the camera rolling the the player
		transform.position = Player.transform.position + Offset;






	}
}