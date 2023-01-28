using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private static int hitCount = 0;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log(++hitCount);
    }
}
