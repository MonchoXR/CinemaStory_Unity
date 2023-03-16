using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetIntesityPointLight : MonoBehaviour
{
    public FollowOnRailPointLight rail;
    public Light _light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Quaternion newRotation = Quaternion.Euler(rail.valueOut,0,0);
        // transform.rotation = newRotation;
        _light.intensity=(rail.valueOut);
        // _light.range=2f;
        //   GetComponent<Light>().intensity=200.0f;
    }
}
