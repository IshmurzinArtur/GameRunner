using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	// Use this for initialization
	public Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.x == -3.01)
			rb.velocity = new Vector3(2, 0, 0);
	}
	
}
