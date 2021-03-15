using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class changeAudio : MonoBehaviour
{
    public AudioClip nightClip;
    public AudioClip dayClip;
    
    public GameObject TimeOfDayManager;
    public AC.TimeOfDaySystemFree.TimeOfDay timeOfDayScript;
    public float dayInSeconds;

    public float delayTime;


    IEnumerator Start()
    {
        timeOfDayScript = TimeOfDayManager.GetComponent<AC.TimeOfDaySystemFree.TimeOfDay>();
        dayInSeconds = timeOfDayScript.dayInSeconds;
        delayTime = dayInSeconds / 2;

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
