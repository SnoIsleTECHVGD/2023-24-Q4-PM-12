using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float bounce = 20f;

    public float strengthOverTime = 1;
    public int maxHeight;

    private int intervalStrength = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce + new Vector2(intervalStrength * strengthOverTime, intervalStrength * strengthOverTime), ForceMode2D.Impulse);
            intervalStrength++;

            intervalStrength = Mathf.Clamp(intervalStrength, 0, maxHeight);
        }
    }
}
