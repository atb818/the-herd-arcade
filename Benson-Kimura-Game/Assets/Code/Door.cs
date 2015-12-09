using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public GameObject door;

	void Start () {
		door.SetActive(true);
	}
	
	void Update () {
		if (EnemyManager.enemies == 0){
			door.SetActive(false);
		}
	}
}
