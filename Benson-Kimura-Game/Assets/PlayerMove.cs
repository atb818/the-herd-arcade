using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMove : MonoBehaviour {


	public float moveForce;
	Rigidbody2D myBody;

	// Use this for initialization
	void Start () {
	
		myBody = this.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		Vector2 moveVec = new Vector2 (CrossPlatformInputManager.GetAxis("Horizontal"), CrossPlatformInputManager.GetAxis("Vertical")) * moveForce;

		myBody.AddForce (moveVec);
	
	}
}
