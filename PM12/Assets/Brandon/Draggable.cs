using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    Vector3 mousePositionOffset;
    public bool lockX;
    float xPos;
    public bool lockY;
    float yPos;
    public bool lockZ;
    float zPos;
    public float dragmultiplier = 1;
    Rigidbody2D RB2D;
    private void Start()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;
        zPos = transform.position.z;
        RB2D = GetComponent<Rigidbody2D>();
    }

    private Vector3 GetMouseWorldPosition()
    {
        // Capture mouse positon & return worldPoint
        return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x * dragmultiplier, Input.mousePosition.y * dragmultiplier, Camera.main.nearClipPlane));
        //return Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
    }


    private void OnMouseDown()
    {
        // Capture the mouse offset
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        RB2D.position = GetMouseWorldPosition() + mousePositionOffset;
        if (lockX) RB2D.position = new Vector3(xPos, RB2D.position.y);
        if (lockY) RB2D.position = new Vector3(RB2D.position.x, yPos);
        if (lockZ) RB2D.position = new Vector3(RB2D.position.x, RB2D.position.y, zPos);
    }
}
