using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameCtrl : MonoBehaviour
{
    public static GameCtrl Ins;
    private int diem;
    [SerializeField] private int thoigian = 120;
    [SerializeField] private GameObject maincam;
    [SerializeField] private GameObject subcam;
    private int solanchet;
    private int diemcaonhat;
    private float vol =0.5f;
    private bool thua = false;
    private bool thang = false;





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

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        instance = this;
        //DontDestroyOnLoad(this.gameObject);
    }

    public void ChoiLai()
    {

    }

    public int TongDiem()
    {
        return Diem*thoigian;
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

    // Start is called before the first frame update
    void Start()
    {

        Scam(false);
        Diem = PlayerPrefs.GetInt("Level");
        Thoigian = thoigian;
        Solanchet = 0;
        Thua = false;
        Thang = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Scam(bool sc) 
    {
        subcam.GetComponent<Camera>().enabled = sc;
    }

}
