using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersController : MonoBehaviour {



    public GameObject camara1;
    public GameObject camara2;
    public GameObject camara3;

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.gameObject.name);
        camara2.SetActive(true);
        camara1.SetActive(false);

    }


    void OnTriggerExit(Collider collider) {

        camara2.SetActive(false);
        camara1.SetActive(true);
    }

}
