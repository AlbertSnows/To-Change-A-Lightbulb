using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBreaks : MonoBehaviour {
    GameObject player;
    Light fanLamp; 
    bool gotItem = false; 
	// Use this for initialization
	void Start () {
        player = GameObject.Find("FirstPersonCharacter");
        fanLamp = GetComponent<Light>();
    }
    IEnumerator BreakLightBulb()
    {
        fanLamp.enabled = true; 
        yield return new WaitForSecondsRealtime(5);
        fanLamp.enabled = false;
        AudioSource lightBulbShattering = this.GetComponent<AudioSource>();
        lightBulbShattering.Play();
        player.SendMessage("SwitchSong"); 
        BroadcastMessage("Appear"); 
    }
}
