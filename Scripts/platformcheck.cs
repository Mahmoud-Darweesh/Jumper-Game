﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformcheck : MonoBehaviour
{

    public GameObject joystick;
    public GameObject jumpbutton;
    // Start is called before the first frame update
    void Start()
    {
        if (!(Application.platform == RuntimePlatform.Android))
        {
            Destroy(joystick);
            Destroy(jumpbutton);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
