using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour {

    public void Clicked()
    {
        print("Recieved!");
         GameObject BrokenLightBulb = GameObject.Find("LightSource");
        BrokenLightBulb.SendMessage("Trigger"); 

    }

}
