using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Save : MonoBehaviour
{

    public GameObject txt;
    public GameObject txt1;
    int scO, scN;

    void Start()
    {

        scN = PlayerPrefs.GetInt("score");
        txt.GetComponent<Text>().text = "Best: " + scN.ToString();
        txt1.GetComponent<Text>().text = "Best: " + scN.ToString();
    }
    public static void SetInt(string KeyName, int Value)
    {
        PlayerPrefs.SetInt(KeyName, Value);
    }

    public static int GetInt(string KeyName)
    {
        return PlayerPrefs.GetInt(KeyName);
    }

    public void SetTxtScore()
    {
        txt.GetComponent<Text>().text = "Best: " + scN.ToString();
        txt1.GetComponent<Text>().text = "Best: " + scN.ToString();
    }

}
