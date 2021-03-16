using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleTriger : MonoBehaviour
{

    private ParticleSystem ps;

    public GameObject TimeOfDayManager;
    public AC.TimeOfDaySystemFree.TimeOfDay timeOfDayScript;
    public float dayInSeconds;

    public float delayTime;

    IEnumerator Start()
    {
        timeOfDayScript = TimeOfDayManager.GetComponent<AC.TimeOfDaySystemFree.TimeOfDay>();
        dayInSeconds = timeOfDayScript.dayInSeconds;
        delayTime = dayInSeconds / 2;

        ps = GetComponent<ParticleSystem>();
        ps.enableEmission = false;
        yield return new WaitForSeconds(delayTime);
        ps.enableEmission = true;
        yield return new WaitForSeconds(delayTime);
        ps.enableEmission = false;
    }

    void Update()
    {
       
    }

}
