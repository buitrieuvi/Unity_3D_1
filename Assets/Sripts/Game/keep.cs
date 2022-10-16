using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keep : MonoBehaviour
{
    public GameObject player;
    public GameObject flat;
    public GameObject MainCam;
    public Animator Boat;

     void Start()
    {
       
    }
    void OnTriggerEnter()
    {
        player.transform.parent = flat.transform;
        MainCam.GetComponent<Camera>().enabled = false;
        Boat.SetBool("bl",true);
        
    }
    void OnTriggerExit()
    {
        player.transform.parent = null;
        MainCam.GetComponent<Camera>().enabled = true;
    }
}
