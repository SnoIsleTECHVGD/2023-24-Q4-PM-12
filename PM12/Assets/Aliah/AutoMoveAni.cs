using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveAni : MonoBehaviour
{
    [SerializeField] float nuMoveSpeed = 3f;

    Rigidbody2D nuRigidbody;
    BoxCollider2D nuBoxCollider;
    public AudioSource audioPlayer;

    void Start()
    {
        nuRigidbody = GetComponent<Rigidbody2D>();
        nuBoxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (NuFacingRight())
        {
            nuRigidbody.velocity = new Vector2(nuMoveSpeed, nuRigidbody.velocity.y);
            GetComponent<Animator>().SetBool("IsFaceRight", true);
        }
        else
        {
            nuRigidbody.velocity = new Vector2(-nuMoveSpeed, nuRigidbody.velocity.y);
            GetComponent<Animator>().SetBool("IsFaceRight", false);
        }
    }
    private bool NuFacingRight()
    {
        return transform.localScale.x > 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "CollisionSoundAudio")
            audioPlayer.Play();
        if (collision.tag == "Swap")
        {
            transform.localScale = new Vector2(-Mathf.Sign(nuRigidbody.velocity.x), transform.localScale.y);
        }
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CollisionSoundAudio")
            audioPlayer.Play();
    }
}
