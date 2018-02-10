using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayer : MonoBehaviour {

	public void OnTriggerEnter(Collider obj) {
		if(obj.gameObject.tag == "Reset Player Barrier") {
			ResetPlayerPosition ();
		}
	}

	private void ResetPlayerPosition() {
		this.gameObject.transform.position = new Vector3(-12, 0, 0);
	}
}
