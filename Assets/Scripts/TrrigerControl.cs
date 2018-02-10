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
		BoxControl boxScript = box.GetComponent<BoxControl>;
		if (boxScript.AllGood == true)
			youCanJump = true;
	}
}
