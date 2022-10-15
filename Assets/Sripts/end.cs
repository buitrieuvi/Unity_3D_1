using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;


public class end : MonoBehaviour
{

    int t,s,tt;
    public GameObject panlend;
    public GameObject txtTime;
    public GameObject txtScore;
    public GameObject txtTotal;


    // Update is called once per frame
    void Update()
    {
        
        

    }
    void OnTriggerEnter()
    {
        Audio.mute(true);
        t = Timer.time;
        s = OnScore.score;
        tt = t * s;
        txtTime.GetComponent<Text>().text = "Time: "+t;
        txtScore.GetComponent<Text>().text = "Score: "+s;
        txtTotal.GetComponent<Text>().text = "Total: " + tt;
        panlend.SetActive(true);


        if (Save.GetInt("score") < tt)
            Save.SetInt("score", tt);

        Save.SetInt("lv1",tt);


        Time.timeScale = 0;
    }


  
}
