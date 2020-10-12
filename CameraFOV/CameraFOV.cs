using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFOV : MonoBehaviour
{


    // Limits
    float startFOV = 15;        //starting
    float minFOV = 10f;         //min zoom limit
    float maxFOV = 20f;         //max zoom limit
    float zoomSpeed = 3f;       //zoom speed
    Camera cam;

    void Awake()
    {
        cam = GetComponent<Camera>();
        cam.fieldOfView = startFOV;
    }

    void LateUpdate()
    {             
        // Zoom (wheel)
        cam.fieldOfView = Mathf.Clamp(cam.fieldOfView - Input.mouseScrollDelta.y * zoomSpeed, minFOV, maxFOV);
    }
}