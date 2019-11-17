using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceController : MonoBehaviour
{
    public void triggerGravityOn()
    {
        Debug.Log("TriggerOn.");
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Renderer>().material.color = Color.red;
    }
}
