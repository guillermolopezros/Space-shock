using UnityEngine;
using System.Collections;

public class Claustrofobia : MonoBehaviour {
	Camera camara;
	public int factor_miedo = 1; // El factor muiedo indicará la velocidad con la que se reduce el campo de visión
	// Use this for initialization
	void Start () {
		//Obtenemos el componente cámara del objeto en el que está insertado el script
		camara = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		camara.fieldOfView = camera.fieldOfView - Time.deltaTime*factor_miedo;
		
	}
}
