using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeTimer : MonoBehaviour
{
    [SerializeField]
    public float timerValue;
    public float timer;
    public bool smokeHasEntered = false;
    bool timerIsRunning = false;

    [SerializeField]
    public GameObject[] SmokeArray;

    private void Start()
    {
        timerIsRunning = true;
        timer = timerValue;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                if (!smokeHasEntered)
                {
                    foreach (GameObject smokeP in SmokeArray)
                    {
                        smokeP.GetComponent<ParticleSystem>().Play();
                    }
                    timer = timerValue/2;
                    smokeHasEntered = true;
                }
                else
                {
                    foreach (GameObject smokeP in SmokeArray)
                    {
                        smokeP.GetComponent<ParticleSystem>().Stop();
                    }
                    timerIsRunning = false;

                }
            }
        }
    }
}
