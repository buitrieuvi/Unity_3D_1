using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float TocDoChuyenDong = 0.5f;
    public GameObject coin;
    public int DiemCoin = 2;

   
    void Start()
    {
        //Instantiate(coin,new Vector3(coin.transform.position.x + 1, coin.transform.position.y, coin.transform.position.z + 1), Quaternion.identity);

    }
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
        transform.Rotate(s, s, s, Space.World);

    }
    
}