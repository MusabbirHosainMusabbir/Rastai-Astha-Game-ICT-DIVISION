using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedTRAFFICsCRIPT : MonoBehaviour
{

    public GameObject RedUITraffic;
    public GameObject TimeBarUi;


    void Start()
    {
        RedUITraffic.SetActive(false);
    }

   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedTraffic")
        {
            RedUITraffic.SetActive(true);
            TimeBarUi.SetActive(false);
        }
    }
}
