using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideDownButtonPrompt : MonoBehaviour
{
    [SerializeField]
    GameObject canvasObject;
    [SerializeField]
    GameObject triggerObject;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, triggerObject.transform.position));
        if (Vector3.Distance(transform.position, triggerObject.transform.position) <= 5f)
        {
            canvasObject.GetComponentInChildren<Text>().text = "Press 'A' to slide down the throat!";
            canvasObject.SetActive(true);
        }
        else
        {
            canvasObject.GetComponentInChildren<Text>().text = "";
            canvasObject.SetActive(false);
        }
    }
}
