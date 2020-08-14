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


        //if (Input.touchCount > 0)
        //{
        //    Touch touch = Input.GetTouch(0);

        //    if (touch.phase == TouchPhase.Moved)
        //    {
        //        dragging = true;
        //        transform.position = Vector3.Lerp(transform.position, touch.position, Time.deltaTime * 20);
        //    }
        //}
        //else
        //{
        //    dragging = false;
        //}

        //if (Input.GetMouseButton(0))
        //{
        //    if (EventSystem.current.IsPointerOverGameObject() || ProcessTap.onMesh)
        //    {
        //        Debug.Log("ui touched");
        //        return;
        //    }

        //    dragging = true;
        //    transform.position = Vector3.Lerp(transform.position, Input.mousePosition, Time.deltaTime * 20);
        //}
        //else
        //{
        //    dragging = false;
        //}

        if (!Utilities.IsPointerOverUIObject())
        {
            //dragging = true;
            transform.position = Vector3.Lerp(transform.position, Input.mousePosition, Time.deltaTime * 20);
        }


    }
}
