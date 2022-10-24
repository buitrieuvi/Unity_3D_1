using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keep2 : MonoBehaviour
{
    public GameObject []mang;
    public float seed = 2;
    public float limit = 20;
    

    // Start is called before the first frame update
    private int soM() => mang.Length;
    void Update()
    {
        for(int i = 0; i < soM(); i++) 
        {
            if (i % 2 == 0)
            {

                mang[i].transform.position = new Vector3(mang[i].transform.position.x + seed * Time.deltaTime,
                                                            mang[i].transform.position.y,
                                                            mang[i].transform.position.z);
                //mang[i].transform.position = new Vector3(mang[i].transform.position.x,
                //                                            mang[i].transform.position.y + seed * Time.deltaTime,
                //                                            mang[i].transform.position.z);
            }
            else
            {
                mang[i].transform.position = new Vector3(mang[i].transform.position.x + -seed * Time.deltaTime,
                                                             mang[i].transform.position.y,
                                                             mang[i].transform.position.z);
                //mang[i].transform.position = new Vector3(mang[i].transform.position.x,
                //                                           mang[i].transform.position.y + -seed * Time.deltaTime,
                //                                           mang[i].transform.position.z);
            }
            if (mang[i].transform.position.x > limit)
                seed = -seed;
        }
        
    }

   


}
