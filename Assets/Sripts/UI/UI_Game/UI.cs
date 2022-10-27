using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour 
{
    public float r = 4;
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * r);
    }
}
