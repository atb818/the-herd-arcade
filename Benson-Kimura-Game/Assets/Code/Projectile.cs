using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	static public int projDir;
	public int Dir;
	Rigidbody2D rb;
	public float speed;

	void Start () {
		projDir = Dir;
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce(new Vector2 (0, speed));
	}
}
