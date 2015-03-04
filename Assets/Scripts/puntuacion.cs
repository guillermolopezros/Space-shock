using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class puntuacion : MonoBehaviour {

	Text texto;

	void Start(){
		texto = gameObject.GetComponent<Text> ();
	}

	void Update(){
		texto.text = Mathf.Round(Time.time).ToString ();
	}

}


