using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingWinScript : MonoBehaviour
{
    public GameObject Uipanel;
    public GameObject TimeBarUi;
    


    // Start is called before the first frame update
    void Start()
    {
        Uipanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CarBox")
        {
            Uipanel.SetActive(true);
           TimeBarUi.SetActive(false);
            

        }

    }
}
