using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameCtrl : MonoBehaviour
{
    public static GameCtrl Ins;
    private int diem;

    [SerializeField] private int thoigian = 60;
    [SerializeField] private GameObject maincam;
    [SerializeField] private GameObject subcam;
    [SerializeField] private GameObject menucam;


    private int solanchet = 0;
    private int diemcaonhat = 0;
    private float vol =0.5f;
    private bool thua = false;
    private bool thang = false;
    public Scrollbar sroll;

    public static GameCtrl instance = null;
    public static GameCtrl Instance
    {
        get
        {
            return instance;
        }
    }

    public int Diem { get => diem; set => diem = value; }
    public int Thoigian { get => thoigian; set => thoigian = value; }
    public bool Thua { get => thua; set => thua = value; }
    public bool Thang { get => thang; set => thang = value; }
    public int Solanchet { get => solanchet; set => solanchet = value; }
    public int Diemcaonhat { get => diemcaonhat; set => diemcaonhat = value; }
    public float Vol { get => vol; set => vol = value; }
    public GameObject Maincam { get => maincam; set => maincam = value; }
    public GameObject Subcam { get => subcam; set => subcam = value; }
    public GameObject Menucam { get => menucam; set => menucam = value; }

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        instance = this;
        //DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        cam(false, false, true);
        
        Diemcaonhat = PlayerPrefs.GetInt("Best");
        Diem = PlayerPrefs.GetInt("Level");
        Time.timeScale = 1;
        sroll.value = PlayerPrefs.GetFloat("Vol_BG");
    }
    void Update()
    {
        volume(sroll.value);
        if (thua) 
        {
            solanchet++;
            PlayerPrefs.SetInt("NumDie", Solanchet);
        }
           
    }
    public void Show()
    {
        Debug.Log("Điểm: " + Diem +
                    " \nThời gian: " + Thoigian +
                    " \nSố lần chết: " + Solanchet +
                    " \nThắng: " + Thang +
                    " \nThua: " + Thua +
                    " \nĐiểm cao nhất: " + Diemcaonhat
                  );
    }
    public int TongDiem()
    {
        return Diem*thoigian;
    }

    public void resetbest()
    {
        PlayerPrefs.SetInt("Best",0);
    }

    public void Replay(int i) 
    {
        if(i ==1)
            Diem = 0;
        else
            Diem = PlayerPrefs.GetInt("Level");

        Time.timeScale = 1;
        Thang = false;
        Thua = false;

        Thoigian = thoigian;

        SceneManager.LoadScene(i);
    }

    public void cam(bool subcam, bool menucam, bool maincam) 
    {
        if(Maincam != null && Menucam != null && Subcam != null) 
        {
            Subcam.GetComponent<Camera>().enabled = subcam;
            Menucam.GetComponent<Camera>().enabled = menucam;
            Maincam.GetComponent<Camera>().enabled = maincam;
        }
    }


    public void volume(float v)
    {
        if (v < 0.5)
            sroll.image.color = Color.green;
        else if (v > 0.5)
            sroll.image.color = Color.red;
        else
            sroll.image.color = Color.white;
        GameAudio.instance.Aus.volume = v;
        GameAudio.instance.Aus_game.volume = v;
        PlayerPrefs.SetFloat("Vol_BG", v);

    }


}
