using UnityEngine;
using System.Collections;

public class CreaRocas : MonoBehaviour {


	public GameObject roca1;
	//public GameObject plat1,plat2,plat3,plat4;
	Vector3 pos;
	int maxposx = 2000;
	int minposx = 2000;
	int maxposy = 5000;
	int minposy = 12;
	int maxposz = 1421;
	int minposz = -559;

	float timeroca =  GameControl.gamecontrol.timeRoca;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		timeroca -= Time.deltaTime;

		if( timeroca < 0){
		pos = new Vector3 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy), Random.Range (maxposz, minposz));
		Instantiate (roca1, pos, Quaternion.identity);
		timeroca = GameControl.gamecontrol.timeRoca;
		}



	}
}
