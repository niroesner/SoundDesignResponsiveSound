using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public AudioSource Explo;
    // Start is called before the first frame update
    void Start()
    {
        Explo = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bomb")
        {
            Explo.Play();
        }

    }
}
