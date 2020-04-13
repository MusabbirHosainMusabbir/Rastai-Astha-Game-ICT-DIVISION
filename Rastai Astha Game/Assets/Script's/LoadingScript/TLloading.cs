using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TLloading : MonoBehaviour
{
    public GameObject TLload;
    // Start is called before the first frame update
    void Start()
    {
        TLload = GameObject.Find("TLLoadingImage");
        TLload.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TLbuttonClick()
    {
        TLload.SetActive(true);
    }
}
