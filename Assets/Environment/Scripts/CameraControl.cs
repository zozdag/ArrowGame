using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    float XMouse,YMouse;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        XMouse = Input.GetAxis("Mouse Y");
        YMouse = Input.GetAxis("Mouse X");

        transform.Rotate(-XMouse, 0, 0);
        transform.Rotate(0, YMouse, 0,Space.World);
        
    }
}
