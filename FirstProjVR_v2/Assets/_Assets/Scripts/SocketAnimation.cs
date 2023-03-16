using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SocketAnimation : MonoBehaviour
{
    
    public GameObject socketObject;

  //Validamos que el GameObject este en el fabricator para que luego no se duplique
  public void RegisterObject(SelectEnterEventArgs args)
  {
    socketObject = args.interactableObject.transform.gameObject;
    
  }

    // Start is called before the first frame update
    public void PlayAnimation( )
    {
        if(socketObject != null){
           Animator[] renderers = socketObject.GetComponentsInChildren<Animator>();
            foreach(Animator rend in renderers)
            {
                rend.enabled=true;
            }
        }
    }

     public void ReleaseObject(){
  
           Animator[] renderers = socketObject.GetComponentsInChildren<Animator>();
            foreach(Animator rend in renderers)
            {
                rend.enabled=false;
            }
    }
    public void StopAnimation( )
    {
        if(socketObject != null){
           Animator[] renderers = socketObject.GetComponentsInChildren<Animator>();
            foreach(Animator rend in renderers)
            {
                rend.enabled=false;
            }
        }
    }


}
