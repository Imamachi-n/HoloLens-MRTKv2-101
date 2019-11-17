using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void changeVoiceControllScene()
    {
        Debug.Log("Change VoiceControl scene.");
        SceneManager.LoadScene("VoiceControl");
    }

    public void changeSpatialAwarenessScene()
    {
        Debug.Log("Change SpatialAwareness scene.");
        SceneManager.LoadScene("SpatialAwareness");
    }
}
