﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersController : MonoBehaviour {

 


    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.gameObject.name);
    }
}
