using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsCuentos : MonoBehaviour
{
    public AudioClip _clipVoice;
    public AudioClip _clipBackground;

    public AudioSource _audioSource;
    // Start is called before the first frame update
    public void PlaySound()
    {
        _audioSource.PlayOneShot(_clipVoice, 0.9f);
        _audioSource.PlayOneShot(_clipBackground, 0.7f);
        _audioSource.Play();
    }

        public void StopSound()
    {
      
        _audioSource.Stop();
    }


}
