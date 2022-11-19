using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DemoOption : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnClickDirectControl()
    {
        SceneManager.LoadScene("DircetControl");
        Debug.Log("Move to direct control scene");
    }

    public void OnClickSmartHomeApplication()
    {
        SceneManager.LoadScene("SmartHome");
        Debug.Log("Move to smart home application control scene");
    }

    public void OnClickVoiceAssistent()
    {
        SceneManager.LoadScene("VoiceAssistent");
        Debug.Log("Move to voice assistent control scene");
    }

    public void OnClickKinect()
    {
        SceneManager.LoadScene("Kinect");
        Debug.Log("Move to kinect control scene");
    }
}
