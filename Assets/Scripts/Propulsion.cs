using UnityEngine;
using System.Collections;

public class Propulsion : MonoBehaviour {

	public int fuerzaPropulsor = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetKey("c")){
			Vector3 pos = transform.position;
			pos.y = pos.y + fuerzaPropulsor;
			transform.position = pos;

		}

		if(Input.GetKey("x")){
			Vector3 pos = transform.position;
			pos.y = pos.y - fuerzaPropulsor;
			transform.position = pos;
			
		}
	}
}
