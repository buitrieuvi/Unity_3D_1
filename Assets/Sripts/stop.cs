using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stop : MonoBehaviour
{

    public bool pg = false;
    public GameObject pnstop;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pg == false)
            {
                Audio.mute(true);
                pnstop.SetActive(true);
                Time.timeScale = 0;
                pg = true;
            }
            else 
            {
                Audio.mute(false);
                pnstop.SetActive(false);
                Time.timeScale = 1;
                pg = false;
            }
            
            
        }
       
    }
}
