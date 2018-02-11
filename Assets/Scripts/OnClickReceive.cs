using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickReceive : MonoBehaviour {
    bool bulbBroken = false; 

    void Start()
    {
    }
    // Update is called once per frame
    void Update () {
	}

    public void Clicked()
    {
        print("Recieved!"); 
        if(bulbBroken == false)
        {
            GameObject Ceiling_Fan = GameObject.Find("Ceiling_Fan");
            Ceiling_Fan.SendMessage("BreakLightBulb");

        }
        bulbBroken = true; 

    }
}
