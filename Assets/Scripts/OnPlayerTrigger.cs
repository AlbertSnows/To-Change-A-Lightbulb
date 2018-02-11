using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerTrigger : MonoBehaviour {
	public GameObject lightSource;
    public Light lightProperty;
    bool hasLightBlub = false; 
    void Start()
    {
        lightProperty = GetComponent<Light>();
        lightSource = this.gameObject;
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetButtonDown("Fire1")&&hasLightBlub==true){
		lightProperty.enabled = !lightProperty.enabled; 
		}
	}

    public void Trigger()
    {
        hasLightBlub = true; 
    }
}
