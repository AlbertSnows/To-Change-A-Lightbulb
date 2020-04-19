using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBreaks : MonoBehaviour {
    GameObject player;
    AudioSource currentSong;
    AudioSource theme;
    AudioSource stone;
    Light fanLamp; 
    bool gotItem = false; 
	// Use this for initialization
	void Start () {
        player = GameObject.Find("FirstPersonCharacter");
        fanLamp = GetComponent<Light>();
        currentSong = GameObject.Find("Beginning").GetComponent<AudioSource>();
        theme = GameObject.Find("Theme").GetComponent<AudioSource>();
        stone = GameObject.Find("Staircase").GetComponent<AudioSource>();
    }
    IEnumerator BreakLightBulb()
    {
        AudioSource lightBulbShattering = this.GetComponent<AudioSource>();
        fanLamp.enabled = true; 
        yield return new WaitForSecondsRealtime(5);
        fanLamp.enabled = false;
        currentSong.Stop();
        lightBulbShattering.Play();
        yield return new WaitForSecondsRealtime(lightBulbShattering.clip.length);
        currentSong = theme;
        currentSong.Play();
        stone.Play();
        // BroadcastMessage("SwitchSong");
        // player.SendMessage("SwitchSong"); 
        BroadcastMessage("Appear"); 
    }
}
