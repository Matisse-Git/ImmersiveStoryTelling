﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartConvo : MonoBehaviour
{
    bool audioStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<SmokeTimer>().smokeHasEntered && !audioStarted){
            GetComponent<AudioSource>().Play();
            audioStarted = true;
        }
    }
}
