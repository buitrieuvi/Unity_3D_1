using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotCham : MonoBehaviour
{
    public GameObject cc;
    public static bool it = false;

    void OnTriggerEnter()
    {
        Destroy(gameObject);
        //if (it == false)
        //{
        //    StartCoroutine(ExampleCoroutine());
        //}
    }

    //void OnCollisionEnter(Collider col)
    //{
    //    if (col.CompareTag("Player")) 
    //    {
    //        if (it == false)
    //        {
    //            StartCoroutine(ExampleCoroutine());
    //        }
    //    }

    //}
    //void OnCollisionEnter()
    //{
    //    if (it == false) 
    //    {
    //        StartCoroutine(ExampleCoroutine());
    //    }


    //}

    IEnumerator ExampleCoroutine()
    {
        it = true;
        Destroy(gameObject);
        yield return new WaitForSeconds(1);
        it = false;
    }
}
