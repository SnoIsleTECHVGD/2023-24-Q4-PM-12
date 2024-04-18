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

    private void Start()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;
        zPos = transform.position.z;
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
        transform.position = GetMouseWorldPosition() + mousePositionOffset;
        if (lockX) transform.position = new Vector3(xPos, transform.position.y);
        if (lockY) transform.position = new Vector3(transform.position.x, yPos);
        if (lockZ) transform.position = new Vector3(transform.position.x, transform.position.y, zPos);
    }
}
