using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class changeAudio : MonoBehaviour
{
    public AudioClip nightClip;
    public AudioClip dayClip;
    public float delayTime = 145F;


    IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        yield return new WaitForSeconds(delayTime);
     
        audio.clip = nightClip;
        audio.volume = 1f;
        audio.Play();

        yield return new WaitForSeconds(delayTime);
        audio.clip = dayClip;
        audio.Play();
    }
}
