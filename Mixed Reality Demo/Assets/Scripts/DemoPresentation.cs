using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoPresentation : MonoBehaviour
{

    [SerializeField]
    private ParticleSystem[] smokers;

    [SerializeField]
    private AudioClip breathing;

    // Start is called before the first frame update
    void Start()
    {
        smokers = new ParticleSystem[12];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Smoke"))
        {
            foreach (ParticleSystem smoke in smokers)
            {
                smoke.Play();
            }
        }
        if (Input.GetButtonDown("Fast"))
        {
            Debug.Log(Input.mousePosition);
        }
    }
}
