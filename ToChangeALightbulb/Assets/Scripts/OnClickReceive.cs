using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickReceive : MonoBehaviour {
    public Light lightSwitch; 
    
    void Start()
    {
        lightSwitch = GetComponent<Light>(); 
    }
    // Update is called once per frame
    void Update () {
	}

    public void Clicked()
    {

        lightSwitch.enabled = !lightSwitch.enabled; 
    }
}
