using UnityEngine;
using System.Collections;

public class GeneradorPlataformas : MonoBehaviour {
	
	public GameObject[] plataforma; //objeto que generamos
	public float tiempoespera = 3;		// Cada cuanto la generaremos
	Vector3 posicion;
	float timer = 0;		// esta variable empezara a contar cuando el juego comience
	
	// Use this for initialization
	void Start () {
		posicion = transform.position;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timer) {
			var altura = Random.Range(-3f,4f);
			var tipoplataforma = Random.Range (0,plataforma.Length);
			
			
			
			var nuevaplataforma = (GameObject)Instantiate(plataforma[tipoplataforma], new Vector3(posicion.x, posicion.y+altura,posicion.z), transform.rotation);	
			timer = Time.time + tiempoespera;
			Destroy(nuevaplataforma,7);
		}
		
	}
}