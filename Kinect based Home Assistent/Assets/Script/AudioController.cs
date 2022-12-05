using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip TelevisonAudioClip;
    AudioSource TelevisionAudio;
    [SerializeField] private AudioClip[] clip;
    private float volumeParameter = 0.1f;
    public bool audioState;

    // Start is called before the first frame update
    void Start()
    {
        TelevisionAudio = GetComponent<AudioSource>();
<<<<<<< Updated upstream
        TelevisionAudio.clip = TelevisonAudioClip;
=======
        audioState = false;
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudio()
    {
        TelevisionAudio.Play();
        Invoke("Play wait for 4sec", 4f);
        audioState = true;
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
        audioState = false;
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
