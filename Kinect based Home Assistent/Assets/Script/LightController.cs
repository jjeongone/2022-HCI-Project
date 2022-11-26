using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light RoomLight;
    private float lightParameter = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        RoomLight = GetComponent<Light>();
        RoomLight.intensity = 0.5f;
        RoomLight.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightOn()
    {
        RoomLight.enabled = true;
        Debug.Log("light on");
    }

    public void LightOff()
    {
        RoomLight.enabled = false;
        Debug.Log("light off");
    }

    public void LightUp()
    {
        if (RoomLight.intensity < 1.0) {
            RoomLight.intensity += lightParameter;
        }
        Debug.Log("light intensity up");
    }

    public void LightDown()
    {
        if (RoomLight.intensity > 0.2) {
            RoomLight.intensity -= lightParameter;
        }
    }
}
