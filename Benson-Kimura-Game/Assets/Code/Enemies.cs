using UnityEngine;
using System.Collections;

public class Enemies : MonoBehaviour {

	public Transform target;

	public float speed;

	void Start () {
		EnemyManager.enemies++;
	}
	
	void FixedUpdate () {
		Move();
	}

	void Move(){
		transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
	}
}
