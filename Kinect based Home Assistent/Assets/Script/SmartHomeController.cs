using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartHomeController : MonoBehaviour
{
    public static bool activated = false;

    public GameObject SmartPhone;
    public GameObject Player;

    int distance = 300;

    void Update()
    {
        // if (OVRInput.GetDown(OVRInput.RawButton.A)) 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            activated = !activated;
            Debug.Log("Open smart phone application");
            if (activated)
            {
                SmartPhone.SetActive(true);
                SmartPhone.transform.position = Player.transform.position + Player.transform.forward * distance;
            }
            else
            {
                SmartPhone.SetActive(false);
            }
        }
    }
}
