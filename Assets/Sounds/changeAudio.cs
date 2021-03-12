using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class changeAudio : MonoBehaviour
{
    public AudioClip otherClip;
    public float delayTime;
    public float dayTime;
    //public GameObject dayNightCycle;



    IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        // dayNightCycle = 
       // dayTime = GetComponent<timeOfDay>();
       // delayTime = dayTime / 2 - 5F;
        audio.Play();
        yield return new WaitForSeconds(145F);
      //  yield return new WaitForSeconds(delayTime);
        audio.clip = otherClip;
        audio.volume = 1f;
        audio.Play();
    }
}
