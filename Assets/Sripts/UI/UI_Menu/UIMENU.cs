using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIMENU : MonoBehaviour
{
    public Button s,q,h,r;
    public VisualElement g,l;
    //public Label t;

    void Start()
    {
        //PlayerPrefs.SetInt("Level", 0);
        var root = GetComponent<UIDocument>().rootVisualElement;

        s = root.Q<Button>("start");
        q = root.Q<Button>("quit");
        h = root.Q<Button>("howtoplay");
        r = root.Q<Button>("rs");


        g = root.Q<VisualElement>("game-panel");
        l = root.Q<VisualElement>("btn-panel");
        
      
        s.clicked += startgamepress;
        q.clicked += quitgamepress;
        h.clicked += howtoplaypress;
        r.text = "Reset Best: " + PlayerPrefs.GetInt("Best");
        r.clicked += rs;


    }

    private void startgamepress() 
    {
        SceneManager.LoadScene(1);
    }
    private void quitgamepress()
    {
        Application.Quit();
    }
    private void howtoplaypress()
    {
        g.style.width  = 900;
        //g.style.height = 900;
        l.style.visibility = Visibility.Hidden;
    }
   
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 2f);
    }
    private void rs() 
    {
        PlayerPrefs.SetInt("Best", 0);
        r.text = "Reset Best: " + PlayerPrefs.GetInt("Best");
    }
    



}
