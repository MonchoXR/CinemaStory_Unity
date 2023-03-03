using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SocketPainter : MonoBehaviour
{
    public GameObject socketObject;
    // Start is called before the first frame update
  public void RegisterObject(SelectEnterEventArgs args)
  {
    socketObject = args.interactableObject.transform.gameObject;
  }

   public void ReleaseObject(){
        socketObject = null;
    }

    public void ChangeMaterial(Material newMaterial)
    {
        if(socketObject != null){
           Renderer[] renderers = socketObject.GetComponentsInChildren<Renderer>();
            foreach(Renderer rend in renderers)
            {
                rend.material = newMaterial;
            }
        }
    }
}
