using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {


    public GameObject autobus;
    public GUISkin miGUI;
    private bool pausado; 

	void Start () {
        pausado = false;
	}

    // Update is called once per frame
    void Update() {

        if (Input.GetKey(KeyCode.UpArrow))
            autobus.GetComponent<Transform>().transform.Translate(Vector3.forward * 1);
 
        if (Input.GetKey(KeyCode.DownArrow))
            autobus.GetComponent<Transform>().transform.Translate(Vector3.back *1);

        if (Input.GetKeyDown(KeyCode.Escape)) 
            pausado = (pausado == true) ? false : true ;
    }

    public int posicionY = 400;
    public int posicionX = 600;

    void OnGUI() {

        if (miGUI)
            GUI.skin = miGUI;

        if (pausado)
        {

          
            int resultX = (Screen.width * 660) / 1266;
            int resultY = (Screen.height * 560) / 931;
            GUI.Box(new Rect(Screen.width / 2 - 380, Screen.height / 2 - 250,  (Screen.width -(Screen.width - resultX)) ,  
            (Screen.height - (Screen.height - resultY))    ), "Información Gestual" );
 

            GUI.Label(new Rect(Screen.width / 2 - 70, Screen.height / 2 , 140, 30), "Cantidad de salud");

        }


    }
  
}
