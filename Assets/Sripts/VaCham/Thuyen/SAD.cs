using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAD : MonoBehaviour
{
    public GameObject house;

    void OnTriggerEnter()
    {
        CameraCtrl.Instance.cam(false, false, true);
        Destroy(gameObject);
    }

    
}
