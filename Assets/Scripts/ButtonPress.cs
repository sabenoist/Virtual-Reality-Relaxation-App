using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public Material buttonInactive;
    public Material buttonActive;
    public GameObject audioToPlay;

    bool buttonUsed = false;

    // the player touches the button
    void OnTriggerEnter(Collider col) {
        GetComponent<MeshRenderer>().material = buttonActive;
    }

    // the player lets go of the button
    void OnTriggerExit(Collider col) {
        if (buttonUsed) {
            return;
        }
        buttonUsed = true;

        GetComponent<MeshRenderer>().material = buttonInactive;
        AudioSource audio = audioToPlay.GetComponent<AudioSource>();
        AudioSource.PlayClipAtPoint(audio.clip, audioToPlay.transform.position);


    }


}
