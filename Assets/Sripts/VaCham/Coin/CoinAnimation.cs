using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinAnimation : MonoBehaviour
{
    public float TocDoChuyenDong = 0.5f;
    void Update()
    {
        
        ChuyenDongTaiCho(TocDoChuyenDong);
    }

    public void ChuyenDongTaiCho(float s)
    {
        transform.Rotate(0, s, 0, Space.World);

    }
}
