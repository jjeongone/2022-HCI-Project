using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject Menu;
    public GameObject SmartPhone;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickTutorial()
    {
        // SceneManager.LoadScene("Tutorial");
        Debug.Log("Tutorial");
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("DemoOption");
        Debug.Log("Start Demo");
    }

    public void OnClickQuit()
    {
        Debug.Log("Quit");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void OnClickHome()
    {
        SceneManager.LoadScene("Title");
        Debug.Log("Move to title");
    }

    public void OnClickBack()
    {
        SceneManager.LoadScene("Title");
        Debug.Log("Move back");
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

    public void OnClickMenu()
    {
        Menu.SetActive(true);
        Debug.Log("Open menu");
    }

    public void onClickResume()
    {
        Menu.SetActive(false);
        Debug.Log("Close menu");
    }
}
