using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_ParkingtimeOff : MonoBehaviour
{

    public GameObject TimeBar;
    public GameObject Times;
    // Start is called before the first frame update
    void Start()
    {
        TimeBar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void timebarFalse()
    {
        TimeBar.SetActive(true);
        Times.SetActive(false);
    }
}
