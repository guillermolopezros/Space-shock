using UnityEngine;
using System.Collections;

public class CuboGranada_Script : MonoBehaviour {

	public GameObject cuboGranada;
	Vector3 pos;
	int maxposx = 853;
	int minposx = -1116;
	int maxposy = 335;
	int minposy = 12;
	int maxposz = 1421;
	int minposz = -559;

	public float timeProxCubo = 3f;

	//int maxGranadas = GameControl.gamecontrol.maxGranadas;
	//int cubosEscena = GameControl.gamecontrol.cubosGranadas;

	bool creaCubo;
	//int cubosEscena = 1;
	//static int maxGranadas = GameControl.maxGranadas;
	//public int maxGranadas = 5;

	// Use this for initialization
	void Start() { 

		}
	// Update is called once per frame
	void Update () {

	}
	


		void OnTriggerEnter(Collider col){
		if (col.transform.tag == "Player") {

			Destroy (gameObject);			
			GameControl.gamecontrol.numGranadas++;
			GameControl.gamecontrol.cubosGranadas--;
			//cubosEscena--;
			Debug.Log ("Granada Recogida");
			Debug.Log ("Granadas: " + GameControl.gamecontrol.numGranadas);
			Debug.Log ("CubosGranada en Escena: " + GameControl.gamecontrol.cubosGranadas);
						

				}
		}

		
}
