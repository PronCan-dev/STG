using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    void Awake()
    {
        Screen.SetResolution(720, 1280, true);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
