using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automove : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;

    Rigidbody2D myRigidbody;
    BoxCollider2D myBoxCollider;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myBoxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsFacingRight())
        {
            myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
        }else
        {
            myRigidbody.velocity = new Vector2(-moveSpeed, myRigidbody.velocity.y);
        }
    }
    private bool IsFacingRight()
    {
        return transform.localScale.x > 0;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.localScale = new Vector2(-(Mathf.Sign(myRigidbody.velocity.x)), transform.localScale.y);
    }
}
