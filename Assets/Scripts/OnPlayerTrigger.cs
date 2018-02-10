using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnPlayerTrigger : MonoBehaviour {
	public GameObject lightSource;
    public Light lightProperty;
    
    void Start()
    {
        lightProperty = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
		    lightProperty.enabled = !lightProperty.enabled; 
            
		}
	}
}
