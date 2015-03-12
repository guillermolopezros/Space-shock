using UnityEngine;
using System.Collections;

public class CreaRocas : MonoBehaviour {


	public GameObject[] rocas;

	Vector3 pos;
	int maxposx = 5000;
	int minposx = -5000;
	int maxposy = 6000;
	int minposy = 5002;
	int maxposz = 5421;
	int minposz = -4559;

	public float timeroca =  GameControl.gamecontrol.timeRoca;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		int queRoca = Random.Range(0,rocas.Length-1);
		timeroca -= Time.deltaTime;
		if( timeroca < 0){
		//pos = new Vector3 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy), Random.Range (maxposz, minposz));
		
	//	int queRoca = Random(0,rocas.Length);
			Instantiate (rocas[queRoca], new Vector3 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy), Random.Range (maxposz, minposz)), Quaternion.identity);
			Instantiate (rocas[queRoca], new Vector3 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy), Random.Range (maxposz, minposz)), Quaternion.identity);
			Instantiate (rocas[queRoca], new Vector3 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy), Random.Range (maxposz, minposz)), Quaternion.identity);
			GameObject roca = (GameObject)Instantiate (rocas[queRoca], new Vector3 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy), Random.Range (maxposz, minposz)), Quaternion.identity);
		timeroca = GameControl.gamecontrol.timeRoca;
		}
		Debug.Log(queRoca);
		Debug.Log(Time.time);

	}
}
