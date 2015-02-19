using UnityEngine;
using System.Collections;

public class CuboGranada_Script : MonoBehaviour {

	public GameObject[] cuboGranada;
	Vector3 pos;
	public int maxposx = 853;
	public int minposx = -1116;
	public int maxposy = 335;
	public int minposy = 12;
	public int maxposz = 1421;
	public int minposz = -559;

	public float timeProxCubo = 3f;

	bool creaCubo;
	//int cubosEscena = 1;
	//static int maxGranadas = GameControl.maxGranadas;
	//public int maxGranadas = 5;

	// Use this for initialization
	void Start() { 

		}
	// Update is called once per frame
	void Update () {

		int maxGranadas = GameControl.maxGranadas;
		int cubosEscena = GameControl.cubosGranadas;


		if(cubosEscena < maxGranadas){
			creaCubo = true;
		}else{
			creaCubo = false;
		}

		timeProxCubo -= Time.deltaTime;


		if (creaCubo && timeProxCubo < 0) {

			pos = new Vector3 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy), Random.Range (maxposz, minposz));
			timeProxCubo+=3;
			Instantiate (cuboGranada[0], pos, Quaternion.identity);
			GameControl.cubosGranadas++;
			//cubosEscena++;
			Debug.Log ("CuboGranadas creado.");
			Debug.Log("Cubos en la escena:" + cubosEscena);
		
		}

	}
	


		void OnTriggerEnter(Collider col){
		if (col.transform.tag == "Player") {

			Destroy (gameObject);			
			GameControl.numGranadas++;
			GameControl.cubosGranadas--;
			//cubosEscena--;
			Debug.Log ("Granada Recogida");
			Debug.Log ("Granadas: " + GameControl.numGranadas);
			Debug.Log ("CubosGranada en Escena: " + GameControl.cubosGranadas);
						

				}
		}

		
}
