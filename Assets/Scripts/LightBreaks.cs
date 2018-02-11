﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBreaks : MonoBehaviour {
    Light fanLamp; 
	// Use this for initialization
	void Start () {
        fanLamp = GetComponent<Light>();
        StartCoroutine(BreakLightBulb());
    }
    IEnumerator BreakLightBulb()
    {
        fanLamp.enabled = true; 
        yield return new WaitForSecondsRealtime(5);
        fanLamp.enabled = false; 
    }
}