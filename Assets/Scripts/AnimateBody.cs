using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateBody : MonoBehaviour {

	private float speed = 0.3f;

	public void Move(float x, float y, float z) {
		float step = speed * Time.deltaTime;
		Vector3 target = new Vector3 (x, y, z);
		transform.position = Vector3.MoveTowards (transform.position, target, step);
	}
}
