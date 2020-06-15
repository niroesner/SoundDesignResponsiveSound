using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    public AudioSource FallDownSound;
    public GameObject respawn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!respawn) return;
        if (this.transform.position.y < -3f)
        {
            this.GetComponent<CharacterController>().enabled = false;
            this.transform.position = respawn.transform.position;
            this.GetComponent<CharacterController>().enabled = true;
            FallDownSound.Play();
        }
    }
}
