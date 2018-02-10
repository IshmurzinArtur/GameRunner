using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrrigerControl : MonoBehaviour {

	// Use this for initialization
	public GameObject box;
	public bool youCanJump = false;
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
		BoxControl bc = box.GetComponent<BoxControl>();
		youCanJump = bc.AllGood;
	}
	void OnTriggerEnter2D(Collider2D a)
	{
		GameObject obj = a.gameObject;
		Rigidbody2D rbObj = obj.GetComponent<Rigidbody2D>();
		rbObj.AddForce(new Vector2(33, 10), ForceMode2D.Impulse);
	}
}
