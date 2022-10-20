using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameCtrl.instance.Thang = true;
        GameAudio.instance.Play_win();
        GameAudio.instance.Aus.mute = true;
        PlayerPrefs.SetInt("Level", GameCtrl.instance.TongDiem());
        if (PlayerPrefs.GetInt("Best") < PlayerPrefs.GetInt("Level"))
            PlayerPrefs.SetInt("Best", PlayerPrefs.GetInt("Level"));
    }
}
