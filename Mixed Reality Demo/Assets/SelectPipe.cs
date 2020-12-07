using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPipe : MonoBehaviour
{
    // Start is called before the first frame update
    public int TriggerPipe = 2;
    void Start()
    {
        if (TriggerPipe == 2)
            transform.position = new Vector3(6, 124, -70);
        else if (TriggerPipe == 1)
            transform.position = new Vector3(-4, 124, -69);
    }
    public float speed;
    // Update is called once per frame
    void Update()
    {
        if(TriggerPipe == 1 || TriggerPipe == 2)
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        if(transform.position.y <= 110 && transform.position.x == -4)
        {
            transform.position = new Vector3(0, 11, -7);
            speed = 0;
        }
        if (transform.position.y <= 100 && transform.position.x == 6)
        {
            transform.position = new Vector3(-4, 129, -83);
            speed = 0;
        }
    }
}
