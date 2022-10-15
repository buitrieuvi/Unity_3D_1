using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnScore : MonoBehaviour
{
    public GameObject s1;
    public GameObject s2;
    public static int score = 0;
    

    // Start is called before the first frame update
    void Start()
    {
            score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        s1.GetComponent<Text>().text = " Score: " + score;
        s2.GetComponent<Text>().text = " Score: " + score;
       
    }
}
