using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
   
    void OnTriggerEnter()
    {
        GameCtrl.instance.Thua = true;
        GameAudio.instance.Play_die();
        GameAudio.instance.Aus.mute = true;



    }
}
