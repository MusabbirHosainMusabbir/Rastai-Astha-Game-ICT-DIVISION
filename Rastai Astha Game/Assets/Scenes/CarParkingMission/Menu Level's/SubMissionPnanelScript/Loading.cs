using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour
{
    public GameObject LoadingIcon;
   
    // Start is called before the first frame update
    void Start()
    {

       // LoadingIcon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LodingPanelOpen()
    {
       LoadingIcon.SetActive(true);

    }
}
