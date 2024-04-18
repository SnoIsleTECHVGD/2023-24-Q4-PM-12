using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Collider2D doorCollider;
    public void DoorOpen()
    {
        doorCollider.enabled = false;
    }
    public void DoorClose()
    { 
        doorCollider.enabled = true; 
    }
    public void DoorToggle()
    {
        if (doorCollider.enabled) doorCollider.enabled = false;
        else doorCollider.enabled = true;
    }
}
