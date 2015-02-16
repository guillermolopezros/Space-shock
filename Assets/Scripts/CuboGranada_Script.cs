using UnityEngine;
using System.Collections;

public class CuboGranada_Script : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}

	void OnTriggerEnter(Collider col){
		
		if (col.transform.tag == "Player") {

						GameControl.NumGranadas++;
						Destroy (gameObject);
						Debug.Log (GameControl.NumGranadas);
						//	GameControl.CuboGranada--;

				}

		}
}
