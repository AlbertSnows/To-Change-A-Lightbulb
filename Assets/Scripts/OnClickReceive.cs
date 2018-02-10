using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickReceive : MonoBehaviour {
    public Light lightSwitch;
    bool bulbBroken = false; 

    void Start()
    {
        lightSwitch = GetComponent<Light>();
    }
    // Update is called once per frame
    void Update () {
	}

    public void Clicked()
    {
        print("Recieved!"); 
        lightSwitch.enabled = !lightSwitch.enabled;
        if(bulbBroken == false)
        {
            GameObject Ceiling_Fan = GameObject.Find("Ceiling_Fan");
            Ceiling_Fan.SendMessage("BreakLightBulb"); 
        }
        bulbBroken = true; 

    }
}
