using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class SocketSound : MonoBehaviour
{
    
    public GameObject socketObject;



     //Validamos que el GameObject este en el fabricator para que luego no se duplique
    public void RegisterObject(SelectEnterEventArgs args)
  {
    socketObject = args.interactableObject.transform.gameObject;
    
  }

    public void ReleaseObject()
    {

        SoundsCuentos[] soundCuentos = socketObject.GetComponentsInChildren<SoundsCuentos>();
        foreach (SoundsCuentos _audioSC in soundCuentos)
        {
            _audioSC.StopSound();
        }
    }

    public void PlaySound()
    {
        if (socketObject != null)
        {
            SoundsCuentos[] soundCuentos = socketObject.GetComponentsInChildren<SoundsCuentos>();
            foreach (SoundsCuentos _audioSC in soundCuentos)
            {
                
                 _audioSC.PlaySound();
            }
        }
    }


    public void StopSound()
    {
        if (socketObject != null)
        {
            SoundsCuentos[] soundCuentos = socketObject.GetComponentsInChildren<SoundsCuentos>();
            foreach (SoundsCuentos _audioSC in soundCuentos)
            {
                _audioSC.StopSound();
            }
        }
    }
}
