using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIMENU : MonoBehaviour
{

    public GameObject htp,ls;
    bool hitory = false;
    public Button s,q,h,r,ab,htr;
    public VisualElement g,l;

    void Start()
    {
        PlayerFest.Instance.PlayerFest_Setdiemtemp(0);
        PlayerFest.Instance.PlayerFest_Setsolanchet(0);
        var root = GetComponent<UIDocument>().rootVisualElement;

        s = root.Q<Button>("start");
        q = root.Q<Button>("quit");
        ab = root.Q<Button>("about");
        h = root.Q<Button>("howtoplay");
        r = root.Q<Button>("rs");
        htr = root.Q<Button>("ls");



        g = root.Q<VisualElement>("game-panel");
        l = root.Q<VisualElement>("btn-panel");
        
      
        s.clicked += startgamepress;
        q.clicked += quitgamepress;
        h.clicked += HtP;
        ab.clicked += aboutpress;
        r.text = "Reset Best: " + PlayerPrefs.GetInt("diemcaonhat");
        r.clicked += rs;
        htr.clicked += Ls_on;


    }
    
    private void startgamepress() 
    {
        
        SceneManager.LoadScene(1);
    }
    private void quitgamepress()
    {
        Application.Quit();
    }
    private void aboutpress()
    {
        SceneManager.LoadScene(7);
    }
    private void howtoplaypress()
    {
        g.style.width  = 900;
        l.style.visibility = Visibility.Hidden;
    }
   
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 2f);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (hitory)
            {
                hitory = false;
                ls.SetActive(hitory);
            }
        }
    }
    private void rs() 
    {
        PlayerFest.Instance.PlayerFest_Resetdiemcaonhat();
        r.text = "Reset Best: " + PlayerPrefs.GetInt("diemcaonhat");
    }
    private void HtP()
    {
        htp.SetActive(true);
        StartCoroutine(n());
        
    }
    private void Ls_on()
    {
        if (hitory == false)
        {
            hitory = true;
            ls.SetActive(hitory);
        }
    }

    IEnumerator n()
    {
        yield return new WaitForSeconds(3);
        htp.SetActive(false);
    }


}
