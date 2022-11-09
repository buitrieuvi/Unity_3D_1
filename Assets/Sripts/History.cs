using UnityEngine;
using System;
using TMPro;
using System.IO;
using System.Collections;
using System.Collections.Generic;


public class History : MonoBehaviour
{
    public TMP_Text txt_diem;
    void Start()
    {
        txt_diem.text = File.ReadAllText("out.txt");
    }

}
