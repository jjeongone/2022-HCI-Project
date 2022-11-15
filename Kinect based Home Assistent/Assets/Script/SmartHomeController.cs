using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartHomeController : MonoBehaviour
{
    public static bool activated = false;

    public GameObject SmartPhone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
