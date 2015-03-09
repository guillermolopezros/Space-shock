using UnityEngine;
using System.Collections;

public class Propulsion : MonoBehaviour {

	public int fuerzaPropulsor = 700;
	// Use this for initialization
	void Start () {

		Physics.gravity = new Vector3 (0, 0, 0);
		//Afectará a los rigidbodies para que no se caigan. Ten en cuenta que cualquier cosa que se esté moviendo, no se caerá nunca
	}
	
	// Update is called once per frame
	void Update () {

	if(Input.GetKey("c")){
			Vector3 pos = transform.position;
			pos.y = pos.y + fuerzaPropulsor;
			transform.position = pos;
			//rigidbody.AddForce(0,fuerzaPropulsor*100,0,ForceMode.Impulse);

		}

		if(Input.GetKey("x")){
			Vector3 pos = transform.position;
			pos.y = pos.y - fuerzaPropulsor;
			transform.position = pos;
			
		}
	}
}
