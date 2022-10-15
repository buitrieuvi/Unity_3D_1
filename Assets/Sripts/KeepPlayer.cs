using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject flat;

    void OnTriggerEnter()
    {
        player.transform.parent = flat.transform;
    }
    void OnTriggerExit()
    {
        player.transform.parent = null;
    }
}
