﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallhanger : MonoBehaviour {

    public float speed = 0.1f;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Appear()
    {
        for (int i = 0; i < 20; i++)
        {
            transform.Translate(speed, 0, 0);
        }
    }

}
