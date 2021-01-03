using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class SmokeTimer : MonoBehaviour
{
    [SerializeField]
    public float timerValue;
    public float timer;
    public bool smokeHasEntered = false;
    bool timerIsRunning = false;

    [SerializeField]
    public GameObject[] SmokeArray;

    [SerializeField]
    GameObject arrowPoint;
    [SerializeField]
    GameObject Canvas;

    [SerializeField]
    XRController controllerRight;

    [SerializeField]
    AudioSource clip;
    bool clipPlayed = false;

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
                if (timer < 5 && !clipPlayed){
                    clipPlayed = true;
                    clip.Play();
                }
            }
            else
            {
                if (!smokeHasEntered)
                {
                    foreach (GameObject smokeP in SmokeArray)
                    {
                        Debug.Log(smokeP);
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
                    arrowPoint.SetActive(true);
                    Canvas.SetActive(true);
                    Canvas.GetComponentInChildren<Text>().text = "You can now return to the mouth.";
                    
                }
            }
        }

        if (controllerRight.inputDevice.IsPressed(InputHelpers.Button.PrimaryButton, out bool isPressed) && isPressed){
            Canvas.SetActive(false);
        }
    }
}
