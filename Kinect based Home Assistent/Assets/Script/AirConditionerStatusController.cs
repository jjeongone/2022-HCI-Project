using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirConditionerStatusController : MonoBehaviour
{
    Renderer airConditionerStatusColor;
    public GameObject airConditioner;

    int currentTemperature;
    bool airConditionerActive;
    float targetTemperature;
    public Text temperatureText;
    // Start is called before the first frame update
    void Start()
    {
        currentTemperature = 29;
        airConditionerActive = false;
        targetTemperature = 24;

        airConditionerStatusColor = airConditioner.GetComponent<Renderer>();
        airConditionerStatusColor.material.color = Color.gray;

        temperatureText.text = currentTemperature.ToString() + "°C";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (airConditionerActive && currentTemperature > targetTemperature) 
        {
            currentTemperature -= 1;
            Debug.Log(currentTemperature);
        }
        temperatureText.text = currentTemperature.ToString() + "°C";
    }

    public void AirConditionerOn()
    {
        airConditionerActive = true;
        airConditionerStatusColor.material.color = Color.blue;
    }

    public void AirConditionerOff()
    {
        airConditionerActive = false;
        airConditionerStatusColor.material.color = Color.gray;
    }
}
