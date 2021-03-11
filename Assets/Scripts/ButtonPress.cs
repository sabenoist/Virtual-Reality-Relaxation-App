using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public Material buttonInactive;
    public Material buttonActive;

    // the player touches the button
    void OnTriggerEnter(Collider col) {
        GetComponent<MeshRenderer>().material = buttonActive;
    }

    // the player lets go of the button
    void OnTriggerExit(Collider col) {
        GetComponent<MeshRenderer>().material = buttonInactive;
    }


}
