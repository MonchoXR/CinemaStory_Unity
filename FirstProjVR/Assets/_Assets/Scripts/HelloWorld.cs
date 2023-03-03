using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int frameCount;
    void Start()
    {
        frameCount=0;
        Debug.Log("Hello World Unity");
    }

    // Update is called once per frame
    void Update()
    {
        frameCount = frameCount+1;
        string CoolMessage = "Frame" + frameCount;
        Debug.LogError("Mi message is: "+ CoolMessage);
    }
}
