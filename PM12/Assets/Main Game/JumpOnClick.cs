using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class JumpOnClick : MonoBehaviour
{
    public float bouNce = 20f;

    public float strengthOverTime = 1;
    public int maxHeight;

    private int intervalStrength = 1;

    public GameObject player;

    public bool nunuOnTop;

    void OnMouseDown()
    {
        if (nunuOnTop == true)
        {
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bouNce + new Vector2(intervalStrength * strengthOverTime, intervalStrength * strengthOverTime), ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            nunuOnTop = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            nunuOnTop = false;
        }
    }
}
