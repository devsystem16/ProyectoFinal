using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


    public GameObject autobus;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow))
            autobus.GetComponent<Transform>().transform.Translate(Vector3.forward * 3);


        if (Input.GetKey(KeyCode.DownArrow))
            autobus.GetComponent<Transform>().transform.Translate(Vector3.back *3);

    }


  
}
