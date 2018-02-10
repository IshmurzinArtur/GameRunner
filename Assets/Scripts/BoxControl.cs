using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public GameObject arrow;
	public bool AllGood = false;
	public GameObject player;
	bool haveArrow = false;
	GameObject myArrow;
	// Update is called once per frame
	void Update () {
		if (player.transform.position.x - this.transform.position.x <= 4 && !haveArrow)
		{
			myArrow = Instantiate(arrow, new Vector3(this.transform.position.x, this.transform.position.y + 2, 0), Quaternion.Euler(0,0,90));
			haveArrow = true;
		}
		if (myArrow != null)
		{
			ArrorControl pt = myArrow.GetComponent<ArrorControl>();
			if (pt.Tap == true)
			{
				AllGood = true;
				Destroy(myArrow);
			}
		}
	}
}
