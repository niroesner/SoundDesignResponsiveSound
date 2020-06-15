using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public Vector3 Respawn;
    public AudioSource Explosion;

    public GameObject Player;
    private GameObject Bomb; 


    // Start is called before the first frame update
    void Start()
    {
        Bomb = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!Player || !Bomb) return;

        float distance = Vector3.Distance(Player.transform.position, Bomb.transform.position);

        if (distance < 1.8f)
        {
            Explosion.Play();
            distance = 2;



            Player.GetComponent<CharacterController>().enabled = false;
            
            Player.transform.position = Respawn;
            Player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
