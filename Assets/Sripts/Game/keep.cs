using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keep : MonoBehaviour
{
    public GameObject player;
    public GameObject flat;
    public Animator Boat;
    public Animator House;

    private bool mc, sc;

    void Start()
    {
        
    }
    void OnTriggerEnter()
    {
        
        player.transform.parent = flat.transform;
        GameCtrl.instance.cam(true,false,false); 
        Boat.SetBool("bl",true); 
        House.SetBool("bl", true);
        //GameAudio.instance.Play_house();

    }
    void OnTriggerExit()
    {
        player.transform.parent = null;
        Destroy(gameObject);
        

    }

   


}
