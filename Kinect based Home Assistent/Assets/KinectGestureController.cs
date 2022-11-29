using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KinectGestureController : MonoBehaviour
{
    public GameObject Device;

    AudioController Television;

    // Start is called before the first frame update
    void Start()
    {
        Television = Device.GetComponent<AudioController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnKinectGestureControlle()
    {
        Television.PlayAudio();
    }
}