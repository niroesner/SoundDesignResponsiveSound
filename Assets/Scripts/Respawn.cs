using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player")
        {
            player.transform.position = respawnPoint.transform.position;
        }
        //player.transform.position = respawnPoint.transform.position;
    }

}
