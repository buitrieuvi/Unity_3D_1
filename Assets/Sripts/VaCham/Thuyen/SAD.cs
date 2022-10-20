using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAD : MonoBehaviour
{
    public GameObject house;

    
    void Update()
    {
        //if(Input.GetKeyDown(KeyCode.L))
        //    MainCam.GetComponent<Camera>().enabled = true;
    }
    void OnTriggerEnter()
    {
        GameCtrl.instance.cam(false, false, true);
        Destroy(gameObject);
    }

    
}
