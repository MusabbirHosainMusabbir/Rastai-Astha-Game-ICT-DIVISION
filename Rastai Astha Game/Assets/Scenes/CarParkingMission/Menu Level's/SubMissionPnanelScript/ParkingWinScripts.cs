using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingWinScripts : MonoBehaviour
{
    [Header("Ui Panel")]
    public GameObject TaskCompleteUipanel;
    public GameObject WinUipanel;
   

    [Header("Parking Box")]
    public GameObject P_ParkingZone;
    public GameObject D_ParkingZone;

    [Header("ParkTriggerInCar")]
    public GameObject FrontTrigger;
    public GameObject BackTrigger;


    [Header("TimeBar")]
    public GameObject TimeBar;
    public GameObject P_ParkingTimeBar;





    // Start is called before the first frame update
    void Start()
    {
        //ui panel
        TaskCompleteUipanel.SetActive(false);
        WinUipanel.SetActive(false);
        

        //Parking Zone
        P_ParkingZone.SetActive(false);
        // D_ParkingZone.SetActive(false);

        //Parking Trigger
        BackTrigger.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {


    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ParkBox")
        {
            TaskCompleteUipanel.SetActive(true);
            D_ParkingZone.SetActive(true);
            TimeBar.SetActive(false);
            BackTrigger.SetActive(true);
            FrontTrigger.SetActive(false);

        }

        else if (other.gameObject.tag == "PParkBox")
        {
            WinUipanel.SetActive(true);
            P_ParkingZone.SetActive(true);
            TimeBar.SetActive(false);
            P_ParkingTimeBar.SetActive(false);

        }

    }
}
