using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {

	public Transform target;
	//RigidBody2D rb;

	public float speed;
	//float range;

	void Start () {
		//rb = GetComponent<RigidBody2D>();
	}
	
	void FixedUpdate () {
		Move();
	}

	void Move(){
		//rb.AddForce()
		//range = Vector2.Distance(transform.position, target.position);
		//transform.Translate(Vector2.MoveTowards(transform.position, target.position, range) * speed * Time.deltaTime);
		transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
	}
}
