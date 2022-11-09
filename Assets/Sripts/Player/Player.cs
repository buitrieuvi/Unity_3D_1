using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject pl;
    // Start is called before the first frame update
    void Start()
    {
        pl = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameCtrl.Instance.Thang || GameCtrl.Instance.Thua) 
        {
            Destroy(gameObject);
        }
    }
}
