using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter()
    {
        GameCtrl.Instance.Thang = true;
        AudioCtrl.Instance.Play_win();
        AudioCtrl.Instance.Aus.mute = true;
        PlayerFest.Instance.PlayerFest_Setdiemcaonhat(GameCtrl.Instance.TongDiem());
        PlayerFest.Instance.PlayerFest_Setdiemtemp(GameCtrl.Instance.TongDiem());

    }
}
