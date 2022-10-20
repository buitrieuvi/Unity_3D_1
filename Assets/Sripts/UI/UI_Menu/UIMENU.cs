using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIMENU : MonoBehaviour
{
    public Button s,q,h;
    public VisualElement g,l;

    void Start()
    {
        PlayerPrefs.SetInt("Level", 0);
        var root = GetComponent<UIDocument>().rootVisualElement;

        s = root.Q<Button>("start");
        q = root.Q<Button>("quit");
        h = root.Q<Button>("howtoplay");


        g = root.Q<VisualElement>("game-panel");
        l = root.Q<VisualElement>("btn-panel");

        s.clicked += startgamepress;
        q.clicked += quitgamepress;
        h.clicked += howtoplaypress;

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
        g.style.width  = 1900;
        l.style.visibility = Visibility.Hidden;
    }
   
    void Update()
    {
        
    }


}
