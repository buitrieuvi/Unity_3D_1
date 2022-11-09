using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : Singleton<CameraCtrl>
{
    [SerializeField] private GameObject maincam;
    [SerializeField] private GameObject subcam;
    [SerializeField] private GameObject menucam;

    public GameObject Maincam { get => maincam; set => maincam = value; }
    public GameObject Subcam { get => subcam; set => subcam = value; }
    public GameObject Menucam { get => menucam; set => menucam = value; }
    // Start is called before the first frame update
    void Start()
    {
        cam(false, false, true);
    }

    public void cam(bool subcam, bool menucam, bool maincam)
    {
        if (Maincam != null && Menucam != null && Subcam != null)
        {
            Subcam.GetComponent<Camera>().enabled = subcam;
            Menucam.GetComponent<Camera>().enabled = menucam;
            Maincam.GetComponent<Camera>().enabled = maincam;
        }
    }
}
