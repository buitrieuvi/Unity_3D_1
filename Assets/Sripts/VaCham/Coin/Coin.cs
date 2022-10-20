using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float TocDoChuyenDong = 0.5f;
    public int DiemCoin = 2;

    void Update()
    {
        ChuyenDongTaiCho(TocDoChuyenDong);
    }
    void OnTriggerEnter()
    {
        Destroy(gameObject);
        GameCtrl.instance.Diem += DiemCoin;
        GameCtrl.instance.Show();
        GameAudio.instance.Play_eat();
    }
    public void ChuyenDongTaiCho(float s)
    {
        transform.Rotate(0, s, 0, Space.World);

    }
    
}