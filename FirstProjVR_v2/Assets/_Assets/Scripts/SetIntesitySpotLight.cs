using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIntesitySpotLight : MonoBehaviour
{
    public FollowOnRailSpotLight rail;
    public Light _light2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Quaternion newRotation = Quaternion.Euler(rail.valueOut,0,0);
        // transform.rotation = newRotation;
        _light2.intensity=(rail.valueOut);
        // _light2.range=20.0f;
        //   GetComponent<Light>().intensity=200.0f;
    }
}
