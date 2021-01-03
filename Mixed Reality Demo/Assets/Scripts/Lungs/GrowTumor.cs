using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowTumor : MonoBehaviour
{
    [SerializeField]
    GameObject Smoke;
    MeshRenderer[] tumoren;
    [SerializeField]
    Animator anim;

    private bool animHasPlayed;
    // Start is called before the first frame update
    void Start()
    {
        tumoren = GetComponentsInChildren<MeshRenderer>();
        for (int i = 0; i < tumoren.Length; i++)
        {
            tumoren[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Smoke.GetComponent<SmokeTimer>().smokeHasEntered);
        if (Smoke.GetComponent<SmokeTimer>().smokeHasEntered)
        {
            Debug.Log("activated");
            for (int i = 0; i < tumoren.Length; i++)
            {
                tumoren[i].enabled = true;
            }
            if (!animHasPlayed){
                anim.Play("Base Layer.growTumors");
                animHasPlayed = true;
            }
        }
        if (!anim.GetCurrentAnimatorStateInfo(0).IsName("growTumors") && animHasPlayed){
            anim.Play("Base Layer.New State");
        }
    }
}
