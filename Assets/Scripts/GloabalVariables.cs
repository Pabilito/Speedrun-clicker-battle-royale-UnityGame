using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloabalVariables : MonoBehaviour
{
    public static GloabalVariables instance;
    public bool paused = false;

    private void Start()
    {
        instance = this;
        DontDestroyOnLoad(instance);
    }
}
