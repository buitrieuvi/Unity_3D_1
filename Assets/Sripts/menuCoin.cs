using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuCoin : MonoBehaviour
{
    public float seed = 25f;
    void Update()
    {
        transform.Rotate(0, seed *Time.deltaTime, 0, Space.World);

    }
}
