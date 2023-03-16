using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{

    public float totalDestructionTime = 2f;
  public List<GameObject> trackedObjects = new List<GameObject>();

  public static ObjectTracker Instance;

    void Awake() {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void Start()
    {
          StartCoroutine(DestroyOverTime());
    }

    void Update()
    {
        
    }

    public void DestroyNow(){
        Debug.Log("Destroy");
        foreach(GameObject go in trackedObjects)
        {
            
            Destroy(go);
        }
        trackedObjects.Clear();//Limpiamos la lista
    }

    public void AddToTracked(GameObject objectToAdd)
    {
        trackedObjects.Add(objectToAdd);
    }

    IEnumerator DestroyOverTime() {
        float timeBetween = totalDestructionTime / trackedObjects.Count;
        foreach(GameObject go in trackedObjects)
        {
            
            Destroy(go);
            yield return new WaitForSeconds(timeBetween);
        }
        trackedObjects.Clear();//Limpiamos la lista
        
    }

}
