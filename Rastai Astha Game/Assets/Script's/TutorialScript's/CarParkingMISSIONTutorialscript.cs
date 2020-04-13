using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarParkingMISSIONTutorialscript : MonoBehaviour
{
    public GameObject Panel;
    public GameObject LastPanel;
    public GameObject LoadingImage;

    [Header("Icon")]
    public GameObject TimeBar;
    public GameObject ExitButton;
    public GameObject cameraSwitchButton;
    public GameObject VaicleHorn;
    public GameObject stearingWheel;
    public GameObject BreakButton;
    public GameObject ExcaletorButton;
    public GameObject GearButton;

    [Header("TextMessage")]
    public GameObject ImageTimeBar;
    public GameObject ImageExitButton;
    public GameObject ImagecameraSwitch;
    public GameObject ImageVaicleHorn;
    public GameObject ImagestearingWheel;
    public GameObject ImageBreakButton;
    public GameObject ImageExcaletorButton;
    public GameObject ImageGearButton;

    [Header("SkipButton")]
    public GameObject ButtonTimeBar;
    public GameObject ButtonExitButton;
    public GameObject ButtoncameraSwitchButton;
    public GameObject ButtonVaicleHorn;
    public GameObject ButtonstearingWheel;
    public GameObject ButtonBreakButton;
    public GameObject ButtonExcaletorButton;
    public GameObject ButtonGearButton;
    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(true);
        LastPanel.SetActive(false);
        LoadingImage.SetActive(false);

        //Stearing Wheel TextMessage & Skip Button setActive false
        ImagestearingWheel.SetActive(false);
        ButtonstearingWheel.SetActive(false);

        //Vaicle Horn TextMessage & Skip Button setActive false
        VaicleHorn.SetActive(false);
        ImageVaicleHorn.SetActive(false);
        ButtonVaicleHorn.SetActive(false);

        //ExitButton TextMessage & Skip Button setActive false
        ExitButton.SetActive(false);
        ImageExitButton.SetActive(false);
        ButtonExitButton.SetActive(false);

        //cameraSwitchButton TextMessage & Skip Button setActive false
        cameraSwitchButton.SetActive(false);
        ImagecameraSwitch.SetActive(false);
        ButtoncameraSwitchButton.SetActive(false);

        //TimeBar TextMessage & Skip Button setActive false
        TimeBar.SetActive(false);
        ImageTimeBar.SetActive(false);
        ButtonTimeBar.SetActive(false);

        //GearButton TextMessage & Skip Button setActive false
        GearButton.SetActive(false);
        ImageGearButton.SetActive(false);
        ButtonGearButton.SetActive(false);

        //ExcaletorButton TextMessage & Skip Button setActive false
        ExcaletorButton.SetActive(false);
        ImageExcaletorButton.SetActive(false);
        ButtonExcaletorButton.SetActive(false);

        //BreakeButton TextMessage & Skip Button setActive false
        BreakButton.SetActive(false);
        ImageBreakButton.SetActive(false);
        ButtonBreakButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {  
    }

    public void PanelGoButton()
    {
        Panel.SetActive(false);

        //Icon setActive False
        TimeBar.SetActive(false);
        ExitButton.SetActive(false);
        cameraSwitchButton.SetActive(false);
        VaicleHorn.SetActive(false);
        BreakButton.SetActive(false);
        ExcaletorButton.SetActive(false);
        GearButton.SetActive(false);


        //Stearing Wheel TextMessage & Skip Button setActive True
        ImagestearingWheel.SetActive(true);
        ButtonstearingWheel.SetActive(true);
    }

    public void StearingWheelSkipButton()
    {
        //Stearing Wheel TextMessage & Skip Button setActive false
        ImagestearingWheel.SetActive(false);
        ButtonstearingWheel.SetActive(false);

        //Icon setActive true
        VaicleHorn.SetActive(true);
        ImageVaicleHorn.SetActive(true);
        ButtonVaicleHorn.SetActive(true);
    }

    public void VaicleHornSkipButton()
    {
        //VaicleHorn TextMessage & Skip Button setActive false
        ImageVaicleHorn.SetActive(false);
        ButtonVaicleHorn.SetActive(false);

        //Icon setActive true
        ExitButton.SetActive(true);
        ImageExitButton.SetActive(true);
        ButtonExitButton.SetActive(true);
    }

    public void ExitSkipButton()
    {
        //ExitButton TextMessage & Skip Button setActive false
        ImageExitButton.SetActive(false);
        ButtonExitButton.SetActive(false);

        //Icon setActive true
        cameraSwitchButton.SetActive(true);
        ImagecameraSwitch.SetActive(true);
        ButtoncameraSwitchButton.SetActive(true);
    }

    public void cameraSwitchSkipButton()
    {
        //cameraSwitch TextMessage & Skip Button setActive false
        ImagecameraSwitch.SetActive(false);
        ButtoncameraSwitchButton.SetActive(false);

        //Icon setActive true
        TimeBar.SetActive(true);
        ImageTimeBar.SetActive(true);
        ButtonTimeBar.SetActive(true);
    }

    public void TimeBarSkipButton()
    {
        //TimeBar TextMessage & Skip Button setActive false
        ImageTimeBar.SetActive(false);
        ButtonTimeBar.SetActive(false);

        //Icon setActive true
        GearButton.SetActive(true);
        ImageGearButton.SetActive(true);
        ButtonGearButton.SetActive(true);
    }

    public void GearSkipButton()
    {
        //GearButton TextMessage & Skip Button setActive false
        ImageGearButton.SetActive(false);
        ButtonGearButton.SetActive(false);

        //Icon setActive true
        ExcaletorButton.SetActive(true);
        ImageExcaletorButton.SetActive(true);
        ButtonExcaletorButton.SetActive(true);
    }

   public void ThrottleSkipButton()
    {
        //ThrottleButton TextMessage & Skip Button setActive false
        ImageExcaletorButton.SetActive(false);
        ButtonExcaletorButton.SetActive(false);

        //Icon setActive true
        BreakButton.SetActive(true);
        ImageBreakButton.SetActive(true);
        ButtonBreakButton.SetActive(true);
    }

    public void BreakeSkipButton()
    {
        //BreakeButton TextMessage & Skip Button setActive false
        ImageBreakButton.SetActive(false);
        ButtonBreakButton.SetActive(false);

        //LastPanel setActive true
        LastPanel.SetActive(true);
    }

   

}
