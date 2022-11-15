using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float rotateSpeed = 10.0f;
    public float zoomSpeed = 10.0f;
    public float movementSpeed = 5f;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = GetComponent<Camera>();
    }
    
    void Update()
    {
        Zoom();
        Rotate();
    }

    private void Zoom()
    {
        float distance = Input.GetAxis("Mouse ScrollWheel") * -1 * zoomSpeed;
        if(distance != 0 && mainCamera.orthographic != true)
        {
            mainCamera.fieldOfView += distance;
        }
        else if (distance != 0 && mainCamera.orthographic == true)
        {
            mainCamera.orthographicSize += distance * 10;
        }
    }

    private void Rotate()
    {
        if (Input.GetMouseButton(2))
        {
            Vector3 rot = transform.rotation.eulerAngles;           // Euler angle representation of camera orientation
            rot.y += Input.GetAxis("Mouse X") * rotateSpeed;        // Mouse X position * rotate speed
            rot.x += -1 * Input.GetAxis("Mouse Y") * rotateSpeed;   // Mouse Y position * rotate speed
            Quaternion q = Quaternion.Euler(rot);                   // Euler angle to quaternion
            q.z = 0;
            transform.rotation = Quaternion.Slerp(transform.rotation, q, 2f);
        }
    }
}
