using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour {

	private const float scaleFactor = 1.0f / 255;

	public Image img;
	private float red;
	private float green;
	private float blue;
	private float alpha;

	private float maxRed;

	private bool countDown;
	private int countsToFlicker;

	void Start() {
		countDown = true;
		countsToFlicker = 0;
		red = maxRed = img.color.r;
		green = img.color.g;
		blue = img.color.b;
		alpha = img.color.a;
	}

	// Update is called once per frame
	void Update () {
		img.color = new Color(red, green, blue, alpha);
		if (countDown) red = green = blue = (red - scaleFactor);
		else red = green = blue = (red + scaleFactor);
		if (red < 0.5f) countDown = false;
		else if (red > maxRed) countDown = true;
	}
}
