using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject t1;
    public GameObject t2;
    public static bool isTackingTime = false;
    public static int time = 120;
    public GameObject PanelDie;


    void Start()
    {
        isTackingTime = false;
        
    }
    void Update()
    {

        if (isTackingTime == false && Die.isDie == false)
        {
            StartCoroutine(onTime());
        }
        
       
    }

    IEnumerator onTime() 
    {
        isTackingTime = true;
        time -= 1;
        t1.GetComponent<Text>().text = " Time: " + time;
        t2.GetComponent<Text>().text = " Time: " + time;
        yield return new WaitForSeconds(1);
        isTackingTime = false;
        if (time == 0)
        {
            Time.timeScale = 0;
            PanelDie.SetActive(true);

        }
    }
}
