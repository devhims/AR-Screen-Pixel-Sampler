using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceOnPlane : MonoBehaviour
{

    [SerializeField] GameObject _objToPlace;
    [SerializeField] ARRaycastManager _raycastManager;
    [SerializeField] ARPlaneManager _planeManager;

    bool _isPlaced;

    void Awake()
    {
        // to keep the screen on while the app is used
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    void Update()
    {
        // only when a touch is registered
        if (Input.touchCount > 0)
        {
            // get the first touch
            Touch touch0 = Input.GetTouch(0);

            if (touch0.phase == TouchPhase.Began)
            {
                // ar raycast 
                List<ARRaycastHit> hits = new List<ARRaycastHit>();

                if (_raycastManager.Raycast(touch0.position, hits, TrackableType.Planes) && _isPlaced == false)
                {
                    // to avoid more than one object placement
                    _isPlaced = true;

                    _objToPlace.transform.position = hits[0].pose.position;

                    Vector3 camForward = Camera.main.transform.forward;
                    camForward = new Vector3(camForward.x, 0, camForward.z).normalized;
                    Quaternion objRot = Quaternion.LookRotation(camForward);

                    _objToPlace.transform.rotation = objRot;

                    _objToPlace.SetActive(true);

                    // find and hide all ar plane prefabs 
                    var ARPlane = FindObjectsOfType<ARPlane>();
                    foreach (var plane in ARPlane)
                    {
                        plane.gameObject.SetActive(false);
                    }

                    // disable plane manager
                    _planeManager.enabled = false;
                }
            }
        }

        // android back key press
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
