using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public const float SENSITIVITY = 1.6f;
    private Camera camera;

    // Use this for initialization
    void Start()
    {
        // GetComponent<Transform>() . . . We will use an easier approach
        // no need to get reference to a GameObject, since this script already belongs to a camera => parent
//	    transform.rotation = Quaternion.Euler(0, 90, 0)*Quaternion.Euler(0,30,0); // actually will summ-up

        print("Parent transform\n" + transform);
        // get child camera
        camera = GetComponentInChildren<Camera>();
        print("Camera transform\n" + camera);
    }
    // Update is called once per frame
    void Update()
    {
        // see Edit->Project Settings->Input->Axes 
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        // mind the order, since mouse's axis differ from camera's axis
        // will be errors with pivots
//        transform.rotation = Quaternion.Euler(-mouseY*SENSITIVITY, mouseX*SENSITIVITY, 0)*transform.rotation;
        /* we rotate mouse's X degrees at camera's Y, for horizontal rotation */

        // note to use localRotation (relative to parent axes) instead of rotation (relative to global axes)
        transform.localRotation = Quaternion.Euler(0, mouseX*SENSITIVITY, 0)*transform.localRotation;
        camera.transform.localRotation = Quaternion.Euler(-mouseY*SENSITIVITY, 0, 0)*camera.transform.localRotation;
    }
}