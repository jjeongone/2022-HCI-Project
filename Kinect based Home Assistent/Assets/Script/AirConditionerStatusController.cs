using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirConditionerStatusController : MonoBehaviour
{
    Renderer airConditionerStatusColor;
    public GameObject airConditioner;
    // Start is called before the first frame update
    void Start()
    {
        airConditionerStatusColor = airConditioner.GetComponent<Renderer>();
        airConditionerStatusColor.material.color = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AirConditionerOn()
    {
        airConditionerStatusColor.material.color = Color.blue;
    }

    public void AirConditionerOff()
    {
        airConditionerStatusColor.material.color = Color.gray;
    }
}
