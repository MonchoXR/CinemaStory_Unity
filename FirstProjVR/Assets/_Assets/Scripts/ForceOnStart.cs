using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceOnStart : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody body;
    public float power;
    void Start()
    {
        body= GetComponent<Rigidbody>();
        body.AddForce(transform.forward * power);
    }

}
