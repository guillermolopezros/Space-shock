using UnityEngine;
using System.Collections;

public class CreaPlat : MonoBehaviour {
	
	
	public GameObject[] plats;

	
	Vector3 pos;
	int maxposx = 4000;
	int minposx = 1000;
	int maxposy = 4000;
	int minposy = -3002;
	int maxposz = 5421;
	int minposz = -4559;
	
	//public float timeroca =  GameControl.gamecontrol.timeRoca;
	
	
	
	
	// Use this for initialization
	void Start () {

		for(int i = 0; i < 10; i++){
			int quePlat = Random.Range(0,plats.Length-1);
			Instantiate (plats[quePlat], new Vector3 (Random.Range (maxposx, minposx), Random.Range (maxposy, minposy), Random.Range (maxposz, minposz)), Quaternion.identity);
		}

		
	}
	
	// Update is called once per frame
	void Update () {




	}
}
