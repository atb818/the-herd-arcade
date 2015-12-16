using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerMove : MonoBehaviour {


	bool faceUp, faceDown, faceLeft, faceRight;
	public GameObject projectile;

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

	void Update(){
		if (CrossPlatformInputManager.GetAxis("Vertical") > 0){
			UP();
		}
		if (CrossPlatformInputManager.GetAxis("Vertical") < 0){
			DOWN();
		}
		if (CrossPlatformInputManager.GetAxis("Horizontal") < 0){
			LEFT();
		}
		if (CrossPlatformInputManager.GetAxis("Horizontal") > 0){
			RIGHT();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {

		}
	}



	public void UP(){
		
		
		faceUp = true;
		faceDown = false;
		faceLeft = false;
		faceRight = false;

		print ("UP");
	}
	
	public void DOWN(){
		
		faceUp = false;
		faceDown = true;
		faceLeft = false;
		faceRight = false;

		print ("DOWN");
	}
	
	public void LEFT(){
		
		faceUp = false;
		faceDown = false;
		faceLeft = true;
		faceRight = false;
		
		Debug.Log ("LEFT");
	}
	
	public void RIGHT(){
		
		
		faceUp = false;
		faceDown = false;
		faceLeft = false;
		faceRight = true;

		Debug.Log ("RIGHT");
	}
}




