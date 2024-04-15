using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    Vector3 mousePositionOffset;
    public bool lockX;
    float xPos;
    public bool lockY;
    float yPos;

    private void Start()
    {
        xPos = transform.position.x;
        yPos = transform.position.y;
    }

    private Vector3 GetMouseWorldPosition()
    {
        // Capture mouse positon & return worldPoint
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
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
    }
}
