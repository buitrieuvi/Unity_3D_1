using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotCham : MonoBehaviour
{
    public GameObject cc;

    void OnTriggerEnter()
    {
        Destroy(gameObject);
    }
}
