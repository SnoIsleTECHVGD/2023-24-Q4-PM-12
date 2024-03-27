using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    Vector3 mousePositionOffset;
    float xPos;

    private void Start()
    {
        xPos = transform.position.x;
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
        transform.position = new Vector3(xPos, transform.position.y);
    }
}
