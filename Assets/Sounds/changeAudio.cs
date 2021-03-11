using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class changeAudio : MonoBehaviour
{
    public AudioClip otherClip;

    IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        yield return new WaitForSeconds(145F);
        audio.clip = otherClip;
        audio.volume = 1f;
        audio.Play();
    }
}
