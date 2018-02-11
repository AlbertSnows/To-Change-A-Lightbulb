using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {
    [SerializeField] private Transform player;
    [SerializeField] private Transform spawnPoint;

    void Start()
    {
            player.transform.position = spawnPoint.transform.position;
    }
}
