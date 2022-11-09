using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
   
    void OnTriggerEnter()
    {
        GameCtrl.Instance.Thua = true;
        AudioCtrl.Instance.Play_die();
        AudioCtrl.Instance.Aus.mute = true;

        
    }
}
