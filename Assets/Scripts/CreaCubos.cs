using UnityEngine;
using System.Collections;

public class CreaCubos : MonoBehaviour {
	
	public GameObject cuboGranada;
	Vector3 pos;
	int maxposx = 853;
	int minposx = -1116;
	int maxposy = 5000;
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
		
		//int maxGranadas = GameControl.maxGranadas;
		//int cubosEscena = GameControl.cubosGranadas;
		
		
		//if(cubosEscena < maxGranadas){
		if(GameControl.gamecontrol.cubosGranadas <= GameControl.gamecontrol.maxGranadas){
			creaCubo = true;
		}else{
			creaCubo = false;
		}
		
		timeProxCubo -= Time.deltaTime;
		
		
		if (creaCubo && timeProxCubo < 0) {
			pos = new Vector3 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy), Random.Range (maxposz, minposz));
			Instantiate (cuboGranada, pos, Quaternion.identity);
			GameControl.gamecontrol.cubosGranadas++;
			//cubosEscena++;
			Debug.Log ("CuboGranadas creado.");
			Debug.Log("Cubos en la escena:" + GameControl.gamecontrol.cubosGranadas);
			
		}
		
	}
}