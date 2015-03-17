using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {




}

	void OnCollisionEnter(Collision asteroide) {
		if (asteroide.transform.tag == "Enemy") {
			Debug.Log("Estas Muerto");
			GameControl.gamecontrol.puntuacionFinal = GameControl.gamecontrol.puntuacion;
			Debug.Log(GameControl.gamecontrol.puntuacionFinal);
		}
		
	}


	}
