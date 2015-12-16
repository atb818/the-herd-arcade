using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public GameObject door;
	public GameObject nextWave;

	void Start () {
		door.SetActive(true);
		nextWave.SetActive (false);
	}
	
	void Update () {
		if (EnemyManager.enemies == 0){
			door.SetActive(false);
		}
	}

	void OnTriggerExit2D (Collider2D player){
		door.SetActive (true);
		nextWave.SetActive (true);
	}
}
