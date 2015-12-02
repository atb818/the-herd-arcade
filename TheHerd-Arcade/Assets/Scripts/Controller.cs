using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

public float Speed = 0f;
private float movex = 0f;
private float movey = 0f;

void Start () {
}

void FixedUpdate () {
	movex = Input.GetAxis ("Horizontal");
	movey = Input.GetAxis ("Vertical");
	GetComponent<Rigidbody2D>().velocity = new Vector2 (movex * Speed, movey * Speed);
}

}
