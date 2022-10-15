using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public static AudioSource aus;
    public GameObject volbar;



    void Start()
    {
        aus = GetComponent<AudioSource>();
        


    }

    public static void mute(bool b)
    {
        if(b)
            aus.Pause();
        else
            aus.Play();
    }
    
}
