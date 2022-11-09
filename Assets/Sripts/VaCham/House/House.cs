using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{

    public GameObject h;
    void OnTriggerEnter()
    {
        Destroy(h);
        CameraCtrl.Instance.Subcam.GetComponent<Camera>().enabled = false;

    }

}
