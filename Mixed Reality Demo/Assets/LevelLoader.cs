using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField]
    float triggerDistance;

    [SerializeField]
    GameObject canvasObject;

    public float timerValue;
    public float timer;
    bool timerIsRunning = false;

    public XRController controllerRight;
    public Animator transition;

    private int sceneNumber = 0;

    void Start()
    {
        timerIsRunning = true;
        timer = timerValue;
    }

    // Update is called once per frame
    void Update()
    {        
        canvasObject.GetComponentInChildren<Text>().text = "The experience will end in " + Mathf.Round(timerValue) + " seconds!";
        canvasObject.SetActive(true);      

        if (timerIsRunning)
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                timerIsRunning = false;
                LoadEndScene();
                sceneNumber++;
            }
        }
    }

    void LoadEndScene()
    {
        if(sceneNumber == 0)
        {
            StartCoroutine(LoadLevel("EndScene"));
        }
        else
        {
            return;
        }
        
    }

    IEnumerator LoadLevel(string level)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(5);

        SceneManager.LoadScene(level);
    }
}
