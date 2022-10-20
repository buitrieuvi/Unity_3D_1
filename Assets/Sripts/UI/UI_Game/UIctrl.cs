using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIctrl : MonoBehaviour
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
    private bool m_Stop = false;

    public static bool isTackingTime = false;


    public static UIctrl instance = null;
    public static UIctrl Instance
    {
        get
        {
            return instance;
        }
    }

    public GameObject Best { get => best; set => best = value; }
    public GameObject Best_1 { get => best_1; set => best_1 = value; }

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }

        instance = this;
        //DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        
        isTackingTime = false;
        Best.GetComponent<Text>().text = " Best: " + GameCtrl.instance.best().ToString();
        Best_1.GetComponent<Text>().text = " Best: " + GameCtrl.instance.best().ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if (isTackingTime == false && GameCtrl.Instance.Thoigian >= 0)
        {
            if (!GameCtrl.instance.Thua && !GameCtrl.instance.Thang)
                StartCoroutine(eThoiGian());
        }
        diem();

        if (GameCtrl.instance.Thua)
            P_thua(true);

        if (GameCtrl.instance.Thang)
            P_win(true);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!m_Stop && !GameCtrl.instance.Thang && !GameCtrl.instance.Thua)
            {
                GameAudio.instance.Aus.Pause();
                P_stop(true);
                Time.timeScale = 0;
                m_Stop = true;
                
            }
            else
            {
                GameAudio.instance.Aus.UnPause();
                P_stop(false);
                Time.timeScale = 1;
                m_Stop = false;
                
            }
       

        }

        if (GameCtrl.instance.Thoigian == 0)
        {
            GameCtrl.instance.Thua = true;
        }
    }

    IEnumerator eThoiGian()
    {

        isTackingTime = true;
        GameCtrl.instance.Thoigian--;
        time.GetComponent<Text>().text = " Time: " + GameCtrl.instance.Thoigian;
        time_1.GetComponent<Text>().text = " Time: " + GameCtrl.instance.Thoigian;
        yield return new WaitForSeconds(1);
        isTackingTime = false;

    }

    private void diem()
    {
        score.GetComponent<Text>().text = " Score: " + GameCtrl.instance.Diem;
        score_1.GetComponent<Text>().text = " Score: " + GameCtrl.instance.Diem;
    }
    public void restbest()
    {
        Best.GetComponent<Text>().text = " Best: "  + GameCtrl.instance.Diemcaonhat;
        Best_1.GetComponent<Text>().text = " Best: "  + GameCtrl.instance.Diemcaonhat;
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
        //if(isTackingTime == false)
        //    StartCoroutine(uiCount());

    }
    public void QuitToMenu()
    {

        PlayerPrefs.SetInt("Level", 0);
        SceneManager.LoadScene(0);

    }

    //int i, j, k = 0;
    //IEnumerator uiCount()
    //{
    //    isTackingTime = true;
    //    if (i <= GameCtrl.instance.Thoigian)
    //    {
    //        T_time.GetComponent<Text>().text = "Time: " + i;
    //        T_time_1.GetComponent<Text>().text = "Time: " + i;
    //    }
    //    if (j <= GameCtrl.instance.Diem)
    //    {
    //        T_score.GetComponent<Text>().text = "Score: " + j;
    //        T_score_1.GetComponent<Text>().text = "Score: " + j;
    //    }
    //    if(k<= GameCtrl.instance.TongDiem())
    //    {
    //        T_total.GetComponent<Text>().text = "Total Score: " + k;
    //        T_total_1.GetComponent<Text>().text = "Total Score: " + k;
    //    }
    //    j++;
    //    i++;
    //    k++;
    //    yield return new WaitForSeconds(0.00000000000000000000000000000000000000001f);
    //    isTackingTime = false;

    //}

    private void endScore()
    {
        T_time.GetComponent<Text>().text = "Time: " + GameCtrl.instance.Thoigian;
        T_time_1.GetComponent<Text>().text = "Time: " + GameCtrl.instance.Thoigian;
        T_score.GetComponent<Text>().text = "Score: " + GameCtrl.instance.Diem;
        T_score_1.GetComponent<Text>().text = "Score: " + GameCtrl.instance.Diem;
        T_total.GetComponent<Text>().text = "Total Score: " + GameCtrl.instance.TongDiem();
        T_total_1.GetComponent<Text>().text = "Total Score: " + GameCtrl.instance.TongDiem();
    }

    

}
