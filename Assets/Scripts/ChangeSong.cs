using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSong : MonoBehaviour {
    AudioClip clip1; 
    AudioClip clip2; 
    AudioSource BGM; 
    public void Start()
    {
        clip1 = GameObject.Find("Audio1").GetComponent<AudioClip>();
        clip2 = GameObject.Find("Audio2").GetComponent<AudioClip>();
        BGM = this.GetComponent<AudioSource>();
        BGM.clip = clip1;
        BGM.Play();
        BGM.loop = true; 
    }
    public void SwitchSong()
    {
        print("Switching!"); 
        BGM.Stop();
        BGM.clip = clip2;
        BGM.Play(); 
    }
}
