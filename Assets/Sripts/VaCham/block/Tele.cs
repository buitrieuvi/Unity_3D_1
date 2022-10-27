using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tele : MonoBehaviour
{
    public Transform t1, t2;
    public GameObject pl;
  
    void Start()
    {
        
    }
    void OnTriggerEnter()
    { 
       pl.transform.position = t2.transform.position;
    }


    //private void OnTriggerExit()
    //{
      
    //    reTele = true;
    //}
}
