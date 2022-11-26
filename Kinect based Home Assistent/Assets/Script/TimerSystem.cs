using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSystem : MonoBehaviour
{
    bool timerActive;
    float timerSecond;
    int timerMinute;
    public Text timerText;
    // Start is called before the first frame update
    void Start()
    {
        timerActive = true;
        timerSecond = 0;
        timerMinute = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerActive = true)
        {
            timerSecond += Time.deltaTime;
            timerText.text = string.Format("{0:D2}:{1:D2}", timerMinute, (int)timerSecond);
            
            if((int)timerSecond > 59)
            {
                timerSecond = 0;
                timerMinute++;
            }
        }
        else
        {
            timerText.text = string.Format("{0:D2}:{1:D2}", timerMinute, (int)timerSecond);
        }
    }
}
