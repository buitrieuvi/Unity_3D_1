using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIctrl : Singleton<UIctrl>
{
    [SerializeField]private GameObject Panel_gameover, Panel_menu, Panel_win, Panel_stop;
    [SerializeField] private GameObject time;
    [SerializeField] private GameObject time_1;
    [SerializeField] private GameObject score, score_1;
    [SerializeField] private GameObject T_time;
    [SerializeField] private GameObject T_time_1;
    [SerializeField] private GameObject T_score;
    [SerializeField] private GameObject T_score_1;
    [SerializeField] private GameObject T_total;
    [SerializeField] private GameObject T_total_1;
    [SerializeField] private GameObject best;
    [SerializeField] private GameObject best_1;
    [SerializeField] private GameObject die;
    [SerializeField] private GameObject die_1;

    private bool m_Stop = false;
    public static bool isTackingTime = false;


    public GameObject Best { get => best; set => best = value; }
    public GameObject Best_1 { get => best_1; set => best_1 = value; }
    public GameObject Die { get => die; set => die = value; }
    public GameObject Die_1 { get => die_1; set => die_1 = value; }

    void Start()
    {
        
        isTackingTime = false;
        Best.GetComponent<Text>().text = " Best: " + PlayerPrefs.GetInt("diemcaonhat");
        Best_1.GetComponent<Text>().text = " Best: " + PlayerPrefs.GetInt("diemcaonhat");
        Die.GetComponent<Text>().text = " Die: " + PlayerPrefs.GetInt("solanchet");
        Die_1.GetComponent<Text>().text = " Die: " + PlayerPrefs.GetInt("solanchet");

    }

    public void upSolanchet() 
    {
        GameCtrl.Instance.Solanchet++;
        PlayerFest.Instance.PlayerFest_Setsolanchet(GameCtrl.Instance.Solanchet);
        Die.GetComponent<Text>().text = " Die: " + PlayerPrefs.GetInt("solanchet");
        Die_1.GetComponent<Text>().text = " Die: " + PlayerPrefs.GetInt("solanchet");
    }

    void Update()
    {

        if (isTackingTime == false && GameCtrl.Instance.Thoigian >= 0)
        {
            if (!GameCtrl.Instance.Thua && !GameCtrl.Instance.Thang)
                StartCoroutine(eThoiGian());
        }
        diem();

        if (GameCtrl.Instance.Thua) 
        {
            P_thua(true);
        }

        if (GameCtrl.Instance.Thang)
            P_win(true);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!m_Stop && !GameCtrl.Instance.Thang && !GameCtrl.Instance.Thua)
            {
                AudioCtrl.Instance.Aus.Pause();
                P_stop(true);
                Time.timeScale = 0;
                m_Stop = true;
                
            }
            else
            {
                AudioCtrl.Instance.Aus.UnPause();
                P_stop(false);
                Time.timeScale = 1;
                m_Stop = false;
                
            }
       

        }

        if (GameCtrl.Instance.Thoigian == 0)
        {
            GameCtrl.Instance.Thua = true;
        }
    }

    IEnumerator eThoiGian()
    {

        isTackingTime = true;
        GameCtrl.Instance.Thoigian--;
        time.GetComponent<Text>().text = " Time: " + GameCtrl.Instance.Thoigian;
        time_1.GetComponent<Text>().text = " Time: " + GameCtrl.Instance.Thoigian;
        yield return new WaitForSeconds(1);
        isTackingTime = false;

    }

    private void diem()
    {
        score.GetComponent<Text>().text = " Score: " + GameCtrl.Instance.Diem;
        score_1.GetComponent<Text>().text = " Score: " + GameCtrl.Instance.Diem;
    }
    public void restbest()
    {
        Best.GetComponent<Text>().text = " Best: "  + GameCtrl.Instance.Diemcaonhat;
        Best_1.GetComponent<Text>().text = " Best: "  + GameCtrl.Instance.Diemcaonhat;
    }

    private void P_thua(bool s)
    {
        Panel_gameover.SetActive(s);
        Panel_menu.SetActive(s);
    }
    private void P_stop(bool s)
    {
        Panel_stop.SetActive(s);
        Panel_menu.SetActive(s);
    }
  
    private void P_win(bool s)
    {
        Panel_win.SetActive(s);
        endScore();
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene(0);
    }

    private void endScore()
    {
        T_time.GetComponent<Text>().text = "Time: " + GameCtrl.Instance.Thoigian;
        T_time_1.GetComponent<Text>().text = "Time: " + GameCtrl.Instance.Thoigian;
        T_score.GetComponent<Text>().text = "Score: " + GameCtrl.Instance.Diem;
        T_score_1.GetComponent<Text>().text = "Score: " + GameCtrl.Instance.Diem;
        T_total.GetComponent<Text>().text = "Total Score: " + GameCtrl.Instance.TongDiem();
        T_total_1.GetComponent<Text>().text = "Total Score: " + GameCtrl.Instance.TongDiem();
    }
}
