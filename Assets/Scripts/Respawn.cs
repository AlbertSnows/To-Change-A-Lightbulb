using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint1;
    [SerializeField] private Transform respawnPoint2;

    void Update()
    {
        if(player.transform.position.y < -2)
        {
            player.transform.position = respawnPoint1.transform.position;
        }
    }

}
