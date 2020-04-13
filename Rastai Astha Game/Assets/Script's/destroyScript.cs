using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyScript : MonoBehaviour
{

     void Update()
    {
        
    }

   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boxess")
        {
            Destroy(other.gameObject);
            
        }
    }

   
}
