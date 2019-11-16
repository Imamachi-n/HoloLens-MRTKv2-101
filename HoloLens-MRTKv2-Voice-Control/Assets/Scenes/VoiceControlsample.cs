using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceControlsample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}

    public void test()
    {
        Debug.Log("OK!!");
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Renderer>().material.color = Color.red;
    }
}
