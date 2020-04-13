using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SitBeltAxtion : MonoBehaviour
{

    public GameObject Panel;
    

    private void Start()
    {
       Panel.SetActive(false);
    }


    public void sitbeltGif()
    {
       if(Panel != null)
        {
            Panel.SetActive(true); 
        }
        
       
    }
    
    
}
