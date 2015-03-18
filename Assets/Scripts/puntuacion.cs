using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class puntuacion : MonoBehaviour {

	Text texto;

	void Start(){
		texto = gameObject.GetComponent<Text> ();
	}

	void Update(){

		if(GameControl.jugando){
		texto.text = Mathf.Round(Time.time).ToString ();
		GameControl.gamecontrol.puntuacion = Mathf.Round (Time.time);
		} else {

		}
	}

}


