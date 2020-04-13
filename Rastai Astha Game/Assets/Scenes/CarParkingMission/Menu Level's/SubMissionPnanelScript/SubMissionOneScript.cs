using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMissionOneScript : MonoBehaviour
{
    [Header("ParkingZone")]
    public GameObject D_ParkingZone;
    public GameObject P_ParkingZone;

    [Header("Panel")]
    public GameObject PopUpImagePanel;
    public GameObject LastImagePanel;
    public GameObject R_LastImagePanel;
    public GameObject TaskCompletePanel;
    

    [Header("Button")]
    public GameObject SkipCamera;
    public GameObject SkipGear;
    public GameObject SkipGear_R;
    public GameObject SkipThrottle;
    public GameObject SkipBreake;


    [Header("Canvas Icon")]
    public GameObject ThrottleButton;
    public GameObject BreakButton;

    [Header("Image")]
    public GameObject Camera;
    public GameObject Gear;
    public GameObject Gear_R;
    public GameObject Throttle;
    public GameObject Breake;
    public GameObject Time;
    public GameObject P_ParkingTime;

    [Header("Others")]
    public GameObject Others;


    // Start is called before the first frame update
    void Start()
    {
        
        //Panel
        PopUpImagePanel.SetActive(true);
        LastImagePanel.SetActive(false);
        R_LastImagePanel.SetActive(false);

       

        //Button
        SkipCamera.SetActive(false);
        SkipGear.SetActive(false);
        SkipGear_R.SetActive(false);
        SkipThrottle.SetActive(false);
        SkipBreake.SetActive(false);

        //Image
        Camera.SetActive(false);
        Gear.SetActive(false);
        Gear_R.SetActive(false);
        Throttle.SetActive(false);
        Breake.SetActive(false);
        Time.SetActive(false);
        P_ParkingTime.SetActive(false);

        //Others

    }


    //Button Function's


    public void SkipPopUpButton()
    {
        PopUpImagePanel.SetActive(false);
        SkipGear.SetActive(true);
        Gear.SetActive(true);
        ThrottleButton.SetActive(false);
        BreakButton.SetActive(false);
    }

    public void SkipGearButton()
    {
        SkipGear.SetActive(false);
        Gear.SetActive(false);

        ThrottleButton.SetActive(true);
        Throttle.SetActive(true);
        SkipThrottle.SetActive(true);
    }

    public void SkipThrottleButton()
    {
        Throttle.SetActive(false);
        SkipThrottle.SetActive(false);

        SkipBreake.SetActive(true);
        Breake.SetActive(true);
        BreakButton.SetActive(true);
    }

    public void SkipBreakeButton()
    {
        Breake.SetActive(false);
        SkipBreake.SetActive(false);

        LastImagePanel.SetActive(true);
    }

    public void PressStartButton()
    {
        LastImagePanel.SetActive(false);
        Time.SetActive(true);
    }

    public void PressNextButton()
    {
        Camera.SetActive(true);
        SkipCamera.SetActive(true);
        TaskCompletePanel.SetActive(false);
        D_ParkingZone.SetActive(false);
        P_ParkingZone.SetActive(true);
    }

    public void CameraSkipButton()
    {
        Camera.SetActive(false);
        SkipCamera.SetActive(false);

        SkipGear_R.SetActive(true);
        Gear_R.SetActive(true);
    }

    public void Grar_RskipButton()
    {
        SkipGear_R.SetActive(false);
        Gear_R.SetActive(false);


        R_LastImagePanel.SetActive(true);
        Time.SetActive(false);
    }

}
