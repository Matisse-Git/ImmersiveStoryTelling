using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField]
    float duration;
    [SerializeField]
    float magnitude;

    public IEnumerator Shake(){
        Vector3 ogPos = transform.localPosition;

        float elapsed = 0;
    
        while (elapsed < duration){
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x,y, ogPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = ogPos;
    }
}

