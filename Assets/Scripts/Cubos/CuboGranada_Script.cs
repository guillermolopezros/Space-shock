using UnityEngine;
using System.Collections;

public class CuboGranada_Script : MonoBehaviour {

	public GameObject cuboGranada;
	Vector3 pos;
	public int maxposx = 853;
	public int minposx = -1116;
	public int maxposy = 335;
	public int minposy = 12;
	public int maxposz = 1421;
	public int minposz = -559;

	public int timeProxCubo = 30;

	bool creaCubo;
	int cubosEscena = 1;
	//static int maxGranadas = GameControl.maxGranadas;
	public int maxGranadas = 5;

	// Use this for initialization
	void Start() { 
		//int maxGranadas = GameControl.maxGranadas;
		//int cubosEscena = GameControl.cubosGranadas;

		}
	// Update is called once per frame
	void Update () {




		creaCubo = (cubosEscena < maxGranadas); 		//Condicional para crear cubo

		timeProxCubo -= Time.deltaTime;


		if (cubosEscena < maxGranadas && timeProxCubo < 0) {
			pos = new Vector3 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy), Random.Range (maxposz, minposz));
			Instantiate (cuboGranada, pos, Quaternion.identity);
			GameControl.cubosGranadas++;
			cubosEscena++;
		}
	}

	void OnTriggerEnter(Collider col){
		
		if (col.transform.tag == "Player") {

			Destroy (gameObject);			
			GameControl.numGranadas++;
			GameControl.cubosGranadas--;
			cubosEscena--;
			Debug.Log ("Granada Recogida");
			Debug.Log ("Granadas: " + GameControl.numGranadas);
			Debug.Log ("CubosGranada en Escena: " + GameControl.cubosGranadas);
						

				}

		}
}
