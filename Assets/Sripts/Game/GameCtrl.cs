using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameCtrl : Singleton<GameCtrl>
{
    private int diem = 0;
    [SerializeField] private int thoigian;
    public int level = 0;
    private int solanchet = 0;
    private int diemcaonhat = 0;
    private float vol =0.5f;
    private bool thua = false;
    private bool thang = false;
    public Scrollbar sroll;

    public int Diem { get => diem; set => diem = value; }
    public int Thoigian { get => thoigian; set => thoigian = value; }
    public bool Thua { get => thua; set => thua = value; }
    public bool Thang { get => thang; set => thang = value; }
    public int Solanchet { get => solanchet; set => solanchet = value; }
    public int Diemcaonhat { get => diemcaonhat; set => diemcaonhat = value; }
    public float Vol { get => vol; set => vol = value; }


    void Start()
    {
        Time.timeScale = 1;
        Solanchet = PlayerPrefs.GetInt("solanchet");
        Diem = PlayerPrefs.GetInt("diem_temp");
        Diemcaonhat = PlayerPrefs.GetInt("diemcaonhat");
        sroll.value = PlayerPrefs.GetFloat("Vol_BG");
    }
    void Update()
    {
        volume(sroll.value);
        if (Thua) 
        {
            Thua = false;
            StartCoroutine(n());
            UIctrl.Instance.upSolanchet();
        }
    }

    public int TongDiem()
    {
        return Diem*thoigian;
    }
    public void resetbest()
    {
        PlayerFest.Instance.PlayerFest_Resetdiemcaonhat();
    }
    public void Replay(int i) 
    {
        if(i==1) 
            Diem = 0;
        else
            Diem = PlayerPrefs.GetInt("diem_temp");

        Time.timeScale = 1;
        Thang = false;
        Thua = false;
        Thoigian = thoigian;
        SceneManager.LoadScene(i);
    }

    public void StartGame()
    {
        Time.timeScale = 1;
        Diem = 0;
        Thang = false;
        Thua = false;
        Thoigian = thoigian;
        SceneManager.LoadScene(1);
    }

    public void volume(float v)
    {
        if (v < 0.5)
            sroll.image.color = Color.green;
        else if (v > 0.5)
            sroll.image.color = Color.red;
        else
            sroll.image.color = Color.white;
        AudioCtrl.Instance.Aus.volume = v;
        AudioCtrl.Instance.Aus_game.volume = v;
        PlayerPrefs.SetFloat("Vol_BG", v);
    }

    IEnumerator n()
    {
        yield return new WaitForSeconds(3);
        Replay(level);
    }
}
