using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{

    int diem;
    int solanchet;
    string ngay;

    public EndGame()
    {
    }

    public int Diem { get => diem; set => diem = value; }
    public int Solanchet { get => solanchet; set => solanchet = value; }
    public string Ngay { get => ngay; set => ngay = value; }
    void OnTriggerEnter()
    {
        File.AppendAllText("out.txt", lichsu().ToString());
        SceneManager.LoadScene(7);
    }
    public String lichsu()
    {
        EndGame ls = new EndGame();
        ls.Diem = GameCtrl.Instance.Diem;
        ls.Solanchet = PlayerPrefs.GetInt("solanchet");
        ls.Ngay = DateTime.Now.ToString();
        return ("Score: " + ls.Diem + " Die: " + ls.Solanchet + " Date: " + ls.Ngay + "\n");
    }
}
