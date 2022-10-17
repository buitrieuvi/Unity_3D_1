using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{

    public GameObject h;
    void OnTriggerEnter()
    {
        Destroy(h);
        GameCtrl.instance.Subcam.GetComponent<Camera>().enabled = false;

    }

}
