using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawCoin : MonoBehaviour
{

    public GameObject c;
    // Start is called before the first frame update
    void Start()
    {
        for(int i= 0; i<=8; i+=2)
            for (int j = 0; j <= 8; j += 2)
                Instantiate(c, new Vector3(c.transform.position.x + i, c.transform.position.y, c.transform.position.z + j), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
