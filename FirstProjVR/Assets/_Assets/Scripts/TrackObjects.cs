using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackObjects : MonoBehaviour
{
    public GameObject destroyEffect;
    // public ObjectTracker objectTracker;

    void Start()
    {
        // objectTracker.AddToTracked(gameObject);
        ObjectTracker.Instance.AddToTracked(gameObject);
    }

    void Update()
    {
        
    }

    void OnDestroy()
    {
        if(gameObject.scene.isLoaded)
        {
            Instantiate(destroyEffect, transform.position, transform.rotation);
        }
        
    }
}
