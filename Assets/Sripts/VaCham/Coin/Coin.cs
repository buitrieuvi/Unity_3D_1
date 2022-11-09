using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int DiemCoin = 2;
    void OnTriggerEnter() 
    {
        Destroy(gameObject);
        GameCtrl.Instance.Diem += DiemCoin;
        AudioCtrl.Instance.Play_eat();
    }
}