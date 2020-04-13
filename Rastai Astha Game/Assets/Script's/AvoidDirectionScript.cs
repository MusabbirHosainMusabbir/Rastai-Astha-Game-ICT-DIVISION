using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvoidDirectionScript : MonoBehaviour
{
    public GameObject AvoidPanel;
    public GameObject TimeBar;

    private void Start()
    {
        AvoidPanel.SetActive(false);
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "AvoidDirection")
        {
            AvoidPanel.SetActive(true);
            TimeBar.SetActive(false);

        }
    }
}
