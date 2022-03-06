using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource[] audioSources;

    void Start()
    {
        audioSources[0].Play();
        Invoke("CallAudioSource1", 195);
    }

    void CallAudioSource1()
    {
        audioSources[1].Play();
    }
}
