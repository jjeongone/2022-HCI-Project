using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartHomeController : MonoBehaviour
{
    public static bool activated = false;

    public GameObject SmartPhone;

    public void OnClickSmartHomeController()
    {
        activated = !activated;
        Debug.Log("Open smart phone application");

        if(activated)
        {
            SmartPhone.SetActive(true);
        }
        else
        {
            SmartPhone.SetActive(false);
        }
    }
}
