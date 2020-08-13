using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UIElementDragger : MonoBehaviour
{
    [HideInInspector]
    public bool dragging;

    public void Update()
    {
        if (EventSystem.current.IsPointerOverGameObject(0) || ProcessTap.onMesh)
        {
            return;
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                dragging = true;
                transform.position = Vector3.Lerp(transform.position, touch.position, Time.deltaTime * 20);
            }
        }
        else
        {
            dragging = false;
        }  
    }
}
