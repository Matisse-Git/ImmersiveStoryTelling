﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkenRoom : MonoBehaviour
{
    [SerializeField]
    GameObject Smoke;

    [SerializeField]
    float newIntensity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Smoke.GetComponent<SmokeTimer>().smokeHasEntered){
            if (GetComponent<Light>().intensity > newIntensity){
                GetComponent<Light>().intensity -=0.005f;
            }
        }  
    }
}
