using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class SlideDownButtonPrompt : MonoBehaviour
{
    [SerializeField]
    string tutorialText;
    [SerializeField]
    string newScene;
    [SerializeField]
    string animName;
    [SerializeField]
    GameObject canvasObject;
    [SerializeField]
    GameObject triggerObject;
    [SerializeField]
    Animator anim;
    [SerializeField]
    float triggerDistance;

    private bool animHasPlayed = false;

    public XRController controllerRight;
    AudioSource clip;

    void Start(){
        clip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, triggerObject.transform.position));
        if (Vector3.Distance(transform.position, triggerObject.transform.position) <= triggerDistance)
        {
            canvasObject.GetComponentInChildren<Text>().text = tutorialText;
            canvasObject.SetActive(true);
            if (controllerRight.inputDevice.IsPressed(InputHelpers.Button.PrimaryButton, out bool isPressed) && isPressed)
            {
                Debug.Log("Button Preessed");
                if (anim != null)
                {
                    anim.enabled = true;
                    anim.Play("Base Layer." + animName);
                    animHasPlayed = true;
                    if (clip != null){
                        clip.Play();
                    }
                }
            }
        }
        else
        {
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName(animName) && animHasPlayed)
            {
                anim.enabled = false;
                SceneManager.LoadScene(newScene);
            }
            canvasObject.GetComponentInChildren<Text>().text = "";
            canvasObject.SetActive(false);
        }
    }
}
