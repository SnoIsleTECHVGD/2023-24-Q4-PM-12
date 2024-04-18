using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceReset : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("JumpPad"))
        {
            foreach (JumpPad t in FindObjectsOfType<JumpPad>())
            {
                t.JumpReset();
            }
        }
    }
}
