using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip TelevisonAudioClip;
    AudioSource TelevisionAudio;
    [SerializeField] private AudioClip[] clip;
    private float volumeParameter = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        TelevisionAudio = GetComponent<AudioSource>();
        TelevisionAudio.clip = TelevisonAudioClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio()
    {
        TelevisionAudio.Play();
        Debug.Log("play");
    }

    public void PauseAudio()
    {
        TelevisionAudio.Pause();
        Debug.Log("pause");
    }

    public void StopAudio()
    {
        TelevisionAudio.Stop();
        Debug.Log("stop");
    }

    public void VolumeUp()
    {
        TelevisionAudio.volume += volumeParameter;
        Debug.Log("volume up");
    }

    public void VolumeDown()
    {
        TelevisionAudio.volume -= volumeParameter;
        Debug.Log("volume down");
    }
}
