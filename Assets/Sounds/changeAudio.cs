using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class changeAudio : MonoBehaviour
{
    public AudioClip otherClip;
    public float delayTime = 145F;


    IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        
        audio.Play();
        yield return new WaitForSeconds(delayTime);
     
        audio.clip = otherClip;
        audio.volume = 1f;
        audio.Play();
    }
}
