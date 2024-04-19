using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class InGameButton : MonoBehaviour
{

    public UnityEvent disableClick;
    public UnityEvent enableClick;
    public bool fieldOn;

    void OnMouseDown()
    {
        fieldOn = !fieldOn;
        if (fieldOn)
        {
            disableClick.Invoke();
        }

        else
        {
            enableClick.Invoke();
        }
    }

}
