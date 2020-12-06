using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartBeat : MonoBehaviour
{
    [SerializeField]
    CameraShake shake;
    
    AudioSource heartbeatSound;
    bool playing = false;
    
    public void Start()
    {
        heartbeatSound = GetComponent<AudioSource>();

    }

    public void Update(){
        if (!playing)
        {
            heartbeatSound.Play();
            playing = true;
            StartCoroutine(shake.Shake());
        } else 
        {
            if (!heartbeatSound.isPlaying){
                playing = false;
            }
        }
    }
}
