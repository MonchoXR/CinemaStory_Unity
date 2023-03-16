using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleForever : MonoBehaviour
{
    public Vector3 setScale = new Vector3(1.0f,1.0f,1.0f);
    public Transform pos; 
    void Start()
    {
        // transform.localScale = transform.localScale + setScale; 

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = ScaleVector(transform.localScale);
        transform.position = pos.position;
    }

    Vector3 ScaleVector( Vector3 inVector ){

        Vector3 outVector;
        outVector = inVector + setScale *Time.deltaTime;
        return outVector;
    }
}
