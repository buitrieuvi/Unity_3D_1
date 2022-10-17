using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class AllMenu : MonoBehaviour
{
    public GameObject txt;
    public GameObject txt1;
    public GameObject intro;
    public GameObject credit;
    public GameObject coin;
    public GameObject txtbest;

    
    public static void Srun(int sc) 
    {
        
        SceneManager.LoadScene(sc);
    }
    public static void QuittoMenu(int sc)
    {
        SceneManager.LoadScene(sc);
    }


    public static void Quit()
    {
        Application.Quit();
    }
    public static void LoadReplay(int sc) 
    {
        Timer.time = 120;
        
        Time.timeScale = 1;
        SceneManager.LoadScene(sc);
        
    }



    public void intropanel() 
    {
        intro.SetActive(true);
    }
    public void creditpanel()
    {
        credit.SetActive(true);
        coin.SetActive(false);

    }
    void Start()
    {
        
        txtbest.GetComponent<Text>().text = " Reset Best: " + PlayerPrefs.GetInt("score").ToString();
        
    }
    public void restBest() 
    {
        PlayerPrefs.SetInt("score", 0);
        txtbest.GetComponent<Text>().text = " Reset Best: " + PlayerPrefs.GetInt("score").ToString();
    }

}
