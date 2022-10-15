using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiCtrl : MonoBehaviour
{

    public GameObject Panel_intro, Panel_credit, Panel_best;

    void Start()
    {
        PlayerPrefs.SetInt("Level", 0);
        Panel_best.GetComponent<Text>().text =" Reset Best: "+ PlayerPrefs.GetInt("Best").ToString();
    }
    public void QuitApp()
    {

        Application.Quit();

    }
    public void Button(int i)
    {
        
        SceneManager.LoadScene(i);
    }
    

    public void SubMenu(GameObject g, bool b)
    {
        g.SetActive(b);
    }

    public void ResetBest()
    {
        PlayerPrefs.SetInt("Best",0);
        Panel_best.GetComponent<Text>().text = " Reset Best: " + PlayerPrefs.GetInt("Best").ToString();
    }

    public void menu_intro()
    {
        SubMenu(Panel_intro, true);
    }
    public void menu_credit()
    {
        SubMenu(Panel_credit, true);
    }
    public void menu_back()
    {
        SubMenu(Panel_credit, false);
        SubMenu(Panel_intro, false);
    }
}
