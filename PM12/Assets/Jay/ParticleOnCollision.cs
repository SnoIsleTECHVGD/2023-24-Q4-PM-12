using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleOnCollision : MonoBehaviour
{

     void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<ParticleSystem>().Play();
        GetComponent<SpriteRenderer>().enabled = true;
    }
}
