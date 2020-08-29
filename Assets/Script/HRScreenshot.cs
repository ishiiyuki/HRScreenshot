using System.Collections;
using System;
using System.IO;
using UnityEngine;

public class HRScreenshot : MonoBehaviour
{
    [Header("superSize")]
    public int superSize = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            string name = "HRimage"+getTimeStamp() + ".png";
            ScreenCapture.CaptureScreenshot(name, superSize);
           
        }
    }

    private string getTimeStamp()
    {
        string time = DateTime.Now.ToString("yyyyMMddHHmmss");
        return time;
    }
}
