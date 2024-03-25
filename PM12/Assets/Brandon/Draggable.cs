using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{
    Vector3 mousePositionOffset;

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
    }
}
