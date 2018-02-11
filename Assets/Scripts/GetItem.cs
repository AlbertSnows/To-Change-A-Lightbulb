using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour {
    GameObject BrokenLightBulb;

    public void Start() {
       BrokenLightBulb = GameObject.Find("LightSource");
    }
    public void Clicked()
    {
        print("Recieved!");
        MeshRenderer Bulb = BrokenLightBulb.GetComponent<MeshRenderer>();
        Bulb.enabled = true;
        Light BulbLight = BrokenLightBulb.GetComponent<Light>();
        BulbLight.enabled = true; 
        BrokenLightBulb.SendMessage("Trigger");
        GameObject thisObject = this.gameObject;
        thisObject.SetActive(false); 
    }

}
