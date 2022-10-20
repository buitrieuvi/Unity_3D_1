using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameAudio: MonoBehaviour
{
    [SerializeField]private AudioClip ate;
    [SerializeField]private AudioClip die;
    [SerializeField]private AudioClip win;
    [SerializeField]private AudioClip house;
    [SerializeField]private AudioClip house2;
    [SerializeField]private AudioSource aus;
    [SerializeField]private AudioSource aus_game;

    public static GameAudio instance = null;
    public static GameAudio Instance
    {
        get
        {
            return instance;
        }
    }
    public AudioClip Ate { get => ate; set => ate = value; }
    public AudioClip Die { get => die; set => die = value; }
    public AudioClip Win { get => win; set => win = value; }
    public AudioSource Aus { get => aus; set => aus = value; }
    public AudioSource Aus_game { get => aus_game; set => aus_game = value; }

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
        aus.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Vol_BG");
        aus_game.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Vol_BG");
    }

    void Update()
    {
        
    }

    public void Play_eat() 
    {
        Aus_game.PlayOneShot(Ate);
    }
    public void Play_die()
    {
        Aus_game.PlayOneShot(Die);
    }
    public void Play_win()
    {
        Aus_game.PlayOneShot(Win);
    }
    public void Play_house()
    {

        Aus_game.PlayOneShot(house);
        Aus_game.PlayOneShot(house2);

    }

}
