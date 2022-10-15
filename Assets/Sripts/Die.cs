using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Die : MonoBehaviour
{
    public GameObject PanelDie;
    public static bool isDie= false;
    public AudioClip die;


    void Start()
    {
        Audio.mute(true);
        isDie = false;
    }
    void Update()
    {
       
            

    }
    void OnTriggerEnter()
    {
        isDie = true;
        if (isDie) 
        {         
            PanelDie.SetActive(true);
            isDie = false;
        }
        
        Audio.aus.PlayOneShot(die);


    }



}
