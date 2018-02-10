using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBreaks : MonoBehaviour {
    Light fanLamp; 
	// Use this for initialization
	void Start () {
        fanLamp = GetComponent<Light>();
        StartCoroutine(BreakLightBulb());
        fanLamp.enabled = false;
    }
    IEnumerator BreakLightBulb()
    {
        yield return new WaitForSecondsRealtime(5); 
    }
}
