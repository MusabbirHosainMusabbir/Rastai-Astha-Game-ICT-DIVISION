using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FwLoading : MonoBehaviour
{
    public GameObject FwLOADING;
    // Start is called before the first frame update
    void Start()
    {
        FwLOADING = GameObject.Find("FWLoadingImage");

        FwLOADING.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FwButtonClick()
    {
        FwLOADING.SetActive(true);
    }
}
