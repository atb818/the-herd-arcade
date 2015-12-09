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

	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);

		//find direction
		if (Input.GetKey(KeyCode.UpArrow)){
			faceUp = true;
			faceDown = false;
			faceLeft = false;
			faceRight = false;
		}
		if (Input.GetKey(KeyCode.DownArrow)){
			faceUp = false;
			faceDown = true;
			faceLeft = false;
			faceRight = false;
		}
		if (Input.GetKey(KeyCode.LeftArrow)){
			faceUp = false;
			faceDown = false;
			faceLeft = true;
			faceRight = false;
		}
		if (Input.GetKey(KeyCode.RightArrow)){
			faceUp = false;
			faceDown = false;
			faceLeft = false;
			faceRight = true;
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

