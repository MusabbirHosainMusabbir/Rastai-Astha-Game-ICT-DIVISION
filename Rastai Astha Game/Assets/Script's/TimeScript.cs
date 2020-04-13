using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public float TimeStart;
    public Text textbox;
    public GameObject Uipanel;
    // Start is called before the first frame update
    void Start()
    {
        textbox.text = TimeStart.ToString();
        Uipanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        TimeStart -= Time.deltaTime;
        textbox.text = "" + (int)TimeStart;

        if (TimeStart <= 0f)
        {
            Uipanel.SetActive(true);
            textbox.text = "" + (int)0f;
        }
        
    }
}
