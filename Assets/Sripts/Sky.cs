using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sky : MonoBehaviour
{
    public float r = 2.2f;
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation",Time.time * r);
    }
}
