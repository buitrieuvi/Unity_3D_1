using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFest : Singleton<PlayerFest>
{
    int diemcaonhat;
    int levelStop;
    int solanchet;
    int diem_temp;



    public void PlayerFest_Setdiemcaonhat(int diemcaonhat)
    {
        this.diemcaonhat = diemcaonhat;
        if(diemcaonhat > PlayerPrefs.GetInt("diemcaonhat"))
            PlayerPrefs.SetInt("diemcaonhat",diemcaonhat);
    }
    public void PlayerFest_Resetdiemcaonhat()
    {
            PlayerPrefs.SetInt("diemcaonhat", 0);
    }

    public int PlayerFest_Getdiemcaonhat() => PlayerPrefs.GetInt("diemcaonhat");
  
    public void PlayerFest_Setsolanchet(int solanchet)
    {
            PlayerPrefs.SetInt("solanchet", solanchet);
    }
    public void PlayerFest_Setdiemtemp(int diem_temp)
    {
        PlayerPrefs.SetInt("diem_temp", diem_temp);
    }

    public int Diemcaonhat { get => diemcaonhat; set => diemcaonhat = value; }
    public int LevelStop { get => levelStop; set => levelStop = value; }
    public int Solanchet { get => solanchet; set => solanchet = value; }
    public int Diem_temp { get => diem_temp; set => diem_temp = value; }
}
