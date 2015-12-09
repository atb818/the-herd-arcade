using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	void Start () {
	
	}
	
	void OnTriggerEnter2D (Collider2D enemy) {
		if (enemy.CompareTag("Enemy")){
			Destroy(enemy.gameObject);
		}
	}
}
