using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up : MonoBehaviour
{
    public GameObject pl;

    void OnTriggerEnter()
    {
        pl.GetComponent<Rigidbody>().AddForce(new Vector3(0, pl.transform.position.y * 4000, 0), ForceMode.Force);
    }
}
