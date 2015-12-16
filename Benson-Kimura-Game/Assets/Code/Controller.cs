using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float Speed = 0f;
	private float movex = 0f;
	private float movey = 0f;
	//direction/orientation
	bool faceUp, faceDown, faceLeft, faceRight;
	//attacking
	public GameObject wU, wD, wL, wR;
	GameObject wpn;
	public float swingLength = .5f;
	public float coolDown = .75f;
	public bool canSwing = true;

	void Start () {
		wpn = wD;
		wU.SetActive(false);
		wD.SetActive(false);
		wL.SetActive(false);
		wR.SetActive(false);
	}

	void Update () {


		GetComponent<Rigidbody2D>().velocity = new Vector2 (Input.GetAxis("Horizontal") * Speed, Input.GetAxis("Vertical") * Speed);

		/*

		//find direction
		if (Input.GetAxis("Vertical") > 0){
			UP();
		}
		if (Input.GetAxis("Vertical") < 0){
			DOWN();
		}
		if (Input.GetAxis("Horizontal") < 0){
			LEFT();
		}
		if (Input.GetAxis("Horizontal") > 0){
			RIGHT();
		}

		//set weapon orientation
		if (faceUp){
			wpn = wU;
		}
		if (faceDown){
			wpn = wD;
		}
		if (faceLeft){
			wpn = wL;
		}
		if (faceRight){
			wpn = wR;
		}

		//attack
		if (Input.GetKeyDown(KeyCode.Space) && canSwing) {
				Swing();
				StartCoroutine("SwingTime");
				canSwing = false;	
			}

*/
	}

	public void UP(){
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);

		faceUp = true;
		faceDown = false;
		faceLeft = false;
		faceRight = false;
	}

	public void DOWN(){
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);

		faceUp = false;
		faceDown = true;
		faceLeft = false;
		faceRight = false;
	}

	public void LEFT(){
		movex = -1;
		movey = 0;
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);

		faceUp = false;
		faceDown = false;
		faceLeft = true;
		faceRight = false;

		Debug.Log ("WORKING");
	}

	public void RIGHT(){
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);

		faceUp = false;
		faceDown = false;
		faceLeft = false;
		faceRight = true;
	}



	void Swing (){
		wpn.SetActive(true);
	}

	IEnumerator SwingTime(){
		yield return new WaitForSeconds (swingLength);
		wU.SetActive(false);
		wD.SetActive(false);
		wL.SetActive(false);
		wR.SetActive(false);
		yield return new WaitForSeconds (coolDown);
		canSwing = true;
	}

}

