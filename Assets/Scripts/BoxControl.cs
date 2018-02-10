using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public GameObject arrow;
	public bool AllGood = false;
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Arrow") != null)
		{
			arrow = GameObject.Find("Arrow");
			ArrorControl pt = arrow.GetComponent<ArrorControl>();
			if (pt.Tap == true)
			{
				AllGood = true;
				Destroy(arrow);
			}
		}
	}
}
