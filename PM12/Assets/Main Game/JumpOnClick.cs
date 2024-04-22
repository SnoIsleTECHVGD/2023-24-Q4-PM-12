using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpOnClick : MonoBehaviour
{
    public float bouNce = 20f;

    public float strengthOverTime = 1;
    public int maxHeight;

    private int intervalStrength = 1;

    public UnityEvent enableClick;
    public GameObject player;

    void OnMouseDown()
    {
        if (enableClick != null)
        {
            enableClick.Invoke();
            player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bouNce + new Vector2(intervalStrength * strengthOverTime, intervalStrength * strengthOverTime), ForceMode2D.Impulse);
        }
    }

}
